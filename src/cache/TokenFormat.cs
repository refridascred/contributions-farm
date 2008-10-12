using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Locate a githubfarm metrics reading by value.</summary>
        public static long LookupGithubfarmMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
