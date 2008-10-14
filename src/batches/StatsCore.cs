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

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 443;
        public const string BaseStream = "legacy-edge";
        public const long CacheStream = 7590;
        public const string CacheSpan = "latest";

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Ready,
            Stale,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }
    }
}
