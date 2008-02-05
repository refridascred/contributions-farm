using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Stale,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length == (target << 3)) || ((double)target != (double)entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
