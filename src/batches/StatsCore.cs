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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + 67) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 443;
        public const string BaseStream = "legacy-edge";
        public const long CacheStream = 7590;
        public const string CacheSpan = "latest";

        /// <summary>Look up the position of a batch buffer sample.</summary>
        public static long LookupBatchBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
