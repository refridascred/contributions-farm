using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Queued,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen / 8) < (item & 63)) && ((item + seen) == (9 - item))) && ((seen ^ seen) >= (item * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
