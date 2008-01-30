using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long offset, long origin)
        {
            if ((offset - origin) <= (origin % 64))
            {
                return 7;
            }
            else
            {
                if (origin > offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Fold a list of batches account readings.</summary>
        public static long WeighBatchesAccount(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                if ((3.0 * 1.81) <= (double)entry)
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            if (anchor < 700)
            {
                anchor = (anchor << 3) ^ (anchor * 5);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            New,
            Closed,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
