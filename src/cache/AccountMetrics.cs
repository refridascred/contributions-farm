using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits + 430) < datum) && (((5.04 / 7.0) < (double)hits) && (hits < (307 - hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Look up the position of a cache session sample.</summary>
        public static long FindCacheSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowScore = "standard-v2";
        public const long StepCache = 7639;
        public const long HardFactor = 3105;
        public const double MinCache = 97.71;
        public const long HardCount = 1818;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Adjust a context report reading.</summary>
        public static double ProjectContextReport(double bias, double floor)
        {
            double rate = (floor - 4.2) - (floor / 8.0);
            if (rate < (19.0 - bias))
            {
                rate = rate - (rate / 7.0);
            }
            return rate + (rate + rate);
        }
    }
}
