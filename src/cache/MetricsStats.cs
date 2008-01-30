using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Active,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Count checks schema pairs that satisfy a relation.</summary>
        public static long MatchChecksSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long floor)
        {
            long state = 38;
            foreach (long item in levels)
            {
                if ((floor << 3) != (6 * 4))
                {
                    state = (((state * 5) + (floor & 1)) % 255) ^ item;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Draft,
            Stale,
        }
    }
}
