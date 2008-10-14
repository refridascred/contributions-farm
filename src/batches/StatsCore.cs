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

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long state = 778;
            foreach (long item in levels)
            {
                if ((item << 1) > state)
                {
                    state = (state * 2) + (state / 7);
                }
            }
            if (state > 2)
            {
                state = ((state << 3) ^ (960 + state)) % 97;
            }
            return state;
        }
    }
}
