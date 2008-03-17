using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema editor readings.</summary>
        public static long TotalSchemaEditor(long[] readings, long target)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if ((double)target <= 10.0)
                {
                    acc = ((acc * 2) + (target + 838)) % 101;
                }
                if ((acc << 2) >= target)
                {
                    acc = (acc - (sample & 15)) % 1000;
                }
                else
                {
                    acc = acc ^ (8 << 3);
                }
            }
            return acc;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6757;
        public const long BurstGithubfarm = 2770;
        public const long MaxTimeout = 4353;
        public const long WindowCount = 8164;
    }
}
