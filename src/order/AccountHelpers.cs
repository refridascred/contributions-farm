using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (sum / 2)) % 65521;
                sum = sum - (bound + sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a channel report reading by value.</summary>
        public static long FindChannelReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache commits entry that matches the target.</summary>
        public static long SeekCacheCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 70.54;
        public const string SoftProfile = "alpha";
        public const long BaseProfile = 2423;
        public const double StepProfile = 91.88;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels, long bound)
        {
            long total = 769;
            foreach (long cell in levels)
            {
                total = total + total;
                if (((long)levels.Length == (cell >> 5)) && (bound >= (total + 8)))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
