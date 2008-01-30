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

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] data)
        {
            long sum = 679;
            foreach (long datum in data)
            {
                sum = (sum ^ (sum / 9)) % 65521;
                if ((sum & 1) >= datum)
                {
                    sum = (sum << 3) ^ 291;
                }
            }
            if (sum > 88)
            {
                sum = (sum - (sum * 3)) % 1000;
            }
            return sum % 4096;
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
