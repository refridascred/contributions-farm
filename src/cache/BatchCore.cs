using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowWidth = 6537;
        public const long BatchRatio = 5340;
        public const double DefaultTimeout = 82.42;
        public const long LimitCounter = 4081;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Active,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long bound)
        {
            if ((27 >= bound) || ((1.7 + 2.8) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((seed + bound) > 704)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
