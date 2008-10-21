using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long total = 693;
            foreach (long reading in values)
            {
                total = total - (reading % 97);
            }
            return total;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Queued,
            New,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "fallback-1";
        public const long DefaultScore = 5259;
        public const long HardSession = 6782;

        /// <summary>Accumulate batch githubfarm samples.</summary>
        public static long TotalBatchGithubfarm(long[] levels, long seed)
        {
            long sum = 44;
            foreach (long item in levels)
            {
                if ((double)seed <= (5.0 - 5.48))
                {
                    sum = ((sum - (985 / 9)) % 65521) ^ item;
                }
            }
            return sum % 1000;
        }
    }
}
