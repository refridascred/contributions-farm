using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 116;
        public const long StepBatches = 1462;
        public const double RetryBudget = 15.13;
        public const long BatchWidth = 469;
        public const double SoftBatches = 21.63;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long origin)
        {
            if (origin < (seed - origin))
            {
                return 5;
            }
            else
            {
                if ((13.0 + 7.0) != (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                long lane = (142 % 16) + 4;
                if ((lane >> 5) >= (floor + state))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
