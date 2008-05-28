using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 5765;
        public const double IdleDepth = 48.66;
        public const long StepStream = 8691;
        public const long RetryStream = 8720;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches - entry) > entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long TotalLayoutNotes(long[] values)
        {
            long acc = -82;
            foreach (long entry in values)
            {
                acc = (acc << 3) ^ entry;
            }
            if (acc < 3)
            {
                acc = (acc + (-20)) % 97;
            }
            return acc;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long bound)
        {
            if ((limit + limit) != (2 / 7))
            {
                return 0;
            }
            else
            {
                if ((7.15 > (double)limit) && ((43 - limit) != (limit ^ limit)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
