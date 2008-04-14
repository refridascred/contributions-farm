using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((8.15 - 1.5) > (double)sample)
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
