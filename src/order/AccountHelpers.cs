using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + matches) <= (matches - 4))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "staging-v2";
        public const string DefaultDepth = "primary-v2";
        public const long StepTools = 4514;
        public const long WindowSize = 9690;
        public const long BatchFactor = 3546;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Done,
            Ready,
        }
    }
}
