using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 21.4;
        public const double BatchReport = 6.9;
        public const long BurstCount = 5656;

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
