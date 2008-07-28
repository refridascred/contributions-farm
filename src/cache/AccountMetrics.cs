using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 54.14;
        public const string HardQueue = "open";
        public const long LimitQueue = 8673;

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 297;
        public const long LimitRatio = 6752;
        public const double BatchScore = 24.21;

        /// <summary>Find the first support format entry that matches the target.</summary>
        public static long SeekSupportFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long total = 91;
            foreach (long item in readings)
            {
                if ((item * 5) >= (item - 956))
                {
                    total = (total << 2) ^ (total + 64);
                }
            }
            return total;
        }

        /// <summary>Count the githubfarm route entries that pass the check.</summary>
        public static long MeasureGithubfarmRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((31 >> 2) > (hits >> 3))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
