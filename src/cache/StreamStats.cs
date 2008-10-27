using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowRatio = 6520;
        public const long StepLayout = 5720;
        public const double IdleLayout = 51.4;
        public const long DefaultLayout = 889;
        public const double RetryLayout = 86.83;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long step)
        {
            if ((step & 3) != (step - 73))
            {
                return 0;
            }
            else
            {
                if ((step + target) != (3 + target))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Failed,
            Draft,
            Idle,
            Paused,
        }
    }
}
