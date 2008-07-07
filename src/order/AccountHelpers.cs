using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] data)
        {
            long result = 89;
            foreach (long reading in data)
            {
                if ((reading <= result) || (result < (reading * 4)))
                {
                    result = ((result * 5) + reading) % 1000;
                }
            }
            if (result > 7)
            {
                result = (result ^ (result << 1)) % 1000;
            }
            return result;
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

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels)
        {
            long mix = 506;
            foreach (long value in levels)
            {
                mix = (mix ^ (value + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Validate report stream readings against a bound.</summary>
        public static bool CheckReportStreamLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
