using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if (((double)step <= (8.0 - 6.42)) && ((double)sum <= (5.25 - 3.0)))
                {
                    sum = ((sum << 3) ^ (long)i) % 101;
                }
                else
                {
                    sum = (sum + (24 & 1)) % 101;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "staging";
        public const long DefaultInterval = 123;
        public const long StepBuffer = 5678;
        public const double LimitSpan = 96.93;
        public const long SoftRatio = 8137;
    }
}
