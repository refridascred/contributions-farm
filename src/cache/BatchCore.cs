using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series)
        {
            long acc = 78;
            foreach (long entry in series)
            {
                acc = (acc ^ entry) % 101;
            }
            if (acc > 9)
            {
                acc = (acc ^ (acc * 4)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Locked,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits >= (datum + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
