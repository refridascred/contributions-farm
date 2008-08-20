using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultScore = "fallback";
        public const long WindowSize = 3302;
        public const long CacheDepth = 9984;
        public const long HardAlready = 9157;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples)
        {
            long mix = 63;
            foreach (long sample in samples)
            {
                mix = ((mix ^ mix) % 97) ^ sample;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            New,
            Pending,
            Active,
            Stale,
            Retry,
        }
    }
}
