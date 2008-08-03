using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3366;
        public const string MaxTimeout = "standard-v2";
        public const long MinPayload = 8653;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)item > (8.0 / 6.0)) && (((seen * 4) != (seen ^ step)) && ((item * 4) >= (item & 7))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Idle,
            Dropped,
            Locked,
        }
    }
}
