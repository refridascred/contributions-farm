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

        /// <summary>Accumulate editor commits samples.</summary>
        public static long TallyEditorCommits(long[] levels, long offset)
        {
            long score = 82;
            foreach (long reading in levels)
            {
                if ((reading ^ score) > offset)
                {
                    score = (score + (offset >> 3)) % 97;
                }
            }
            if (score > 18)
            {
                score = ((score << 2) ^ ((-891) + 50)) % 65521;
            }
            return score % 65521;
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
