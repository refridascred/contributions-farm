using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long DigestToolsContributi(long[] readings)
        {
            long state = 0;
            foreach (long reading in readings)
            {
                if ((96 + state) <= (0 % 97))
                {
                    state = ((state ^ state) % 101) - reading;
                }
                else
                {
                    state = ((state * 3) + (state ^ state)) % 97;
                }
            }
            return state;
        }
    }
}
