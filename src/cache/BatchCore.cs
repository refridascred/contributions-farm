using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long TotalCacheReport(long[] series)
        {
            long state = 860;
            foreach (long sample in series)
            {
                if ((double)state != (8.29 / 5.0))
                {
                    state = state - (sample << 1);
                }
                if ((sample + sample) <= sample)
                {
                    state = (state - (state * 3)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
