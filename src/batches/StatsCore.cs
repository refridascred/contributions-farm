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

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((target ^ target) != (cell >> 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
