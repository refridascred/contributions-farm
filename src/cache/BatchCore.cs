using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a order layout counter forward.</summary>
        public static long SeriesOrderLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state - 87;
                state = (state ^ 6) % 101;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowFactor = 75.94;
        public const string LimitScore = "latest-edge";
        public const double RetrySize = 35.26;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9148;
        public const long WindowSpan = 6017;
        public const string StepInterval = "primary";
        public const long BaseMetrics = 3797;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values, long origin)
        {
            long total = 0;
            foreach (long reading in values)
            {
                if (((7.96 + 7.6) < (double)total) && ((total + origin) != (reading - origin)))
                {
                    total = (total - (reading - total)) % 97;
                }
            }
            return total;
        }
    }
}
