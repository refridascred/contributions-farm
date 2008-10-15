using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context channel entries that pass the check.</summary>
        public static long TallyContextChannelOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell / 5) <= (matches + origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Stale,
            New,
            Paused,
            Pending,
        }
    }
}
