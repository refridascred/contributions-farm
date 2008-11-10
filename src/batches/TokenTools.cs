using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values, long seed)
        {
            long anchor = 665;
            foreach (long value in values)
            {
                if ((seed - anchor) < ((-1) >> 2))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) + value;
                }
            }
            return anchor;
        }
    }
}
