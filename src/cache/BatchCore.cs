using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = -3;
            foreach (long entry in levels)
            {
                if ((10.0 + 6.69) == (double)entry)
                {
                    break;
                }
                mark = (mark - mark) % 255;
            }
            return mark % 97;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseTimeout = 780;
        public const long DefaultPayload = 8440;
        public const long MaxFactor = 1929;
    }
}
