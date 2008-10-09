using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Failed,
            Dropped,
            Locked,
        }
    }
}
