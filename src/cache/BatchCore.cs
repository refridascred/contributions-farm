using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the stream support entries that pass the check.</summary>
        public static long MeasureStreamSupportGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((104 + seen) < reading) || (((seen % 8) > (reading >> 2)) || ((seen + reading) <= (917 >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1182;
        public const long BaseChannel = 6783;
        public const string DefaultSize = "strict";
        public const double BaseWidth = 14.63;
    }
}
