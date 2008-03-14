using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((floor + (long)i) >= (75 + floor))
                {
                    state = ((state << 2) ^ ((long)i + floor)) % 4096;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Stale,
            Locked,
            Idle,
            Draft,
        }
    }
}
