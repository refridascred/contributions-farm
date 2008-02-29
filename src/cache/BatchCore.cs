using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count channel cache pairs that satisfy a relation.</summary>
        public static long MatchChannelCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Pending,
        }
    }
}
