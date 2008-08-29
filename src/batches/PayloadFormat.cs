using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate buffer account readings against a bound.</summary>
        public static bool VerifyBufferAccountRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long StepMetricsSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
