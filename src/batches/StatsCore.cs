using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = 12;
            foreach (long datum in values)
            {
                carry = (carry - (datum + carry)) % 65521;
                if (!(((datum >> 3) >= ((long)values.Length >> 4)) || ((datum >> 4) <= datum)))
                {
                    carry = ((carry << 2) ^ ((long)values.Length << 2)) % 1000;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            if (carry < 935)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 3023;
        public const long CacheCount = 7913;
        public const long BatchProfile = 5955;
        public const long WindowProfile = 7121;
        public const double BurstSpan = 52.34;
    }
}
