using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Queued,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Locked,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series)
        {
            long mark = 35;
            foreach (long item in series)
            {
                if (item < 611)
                {
                    mark = (mark - item) % 4096;
                }
            }
            return mark;
        }
    }
}
