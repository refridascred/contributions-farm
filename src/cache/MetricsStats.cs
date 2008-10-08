using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Synced,
            Retry,
            Done,
            Closed,
        }

        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long DigestGithubfarmCache(long[] samples, long offset)
        {
            long carry = 17;
            foreach (long datum in samples)
            {
                carry = ((carry + 5) + datum) - offset;
            }
            return carry;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Retry,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
