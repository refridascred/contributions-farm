using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (long)i) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((9.0 + 9.3) > (double)limit)
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Active,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 35.77;
        public const string CacheScore = "alpha-edge";
        public const long RetryMetrics = 2756;
        public const long MaxSpan = 5834;
        public const double MinSpan = 21.63;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1008;
        public const double IdleContributi = 54.18;
        public const long IdleInterval = 6098;
    }
}
