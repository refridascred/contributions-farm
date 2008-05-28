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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if ((48 < (step << 3)) || ((step ^ (long)i) >= result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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
