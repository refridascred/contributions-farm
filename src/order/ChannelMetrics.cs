using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a farm githubfarm reading by value.</summary>
        public static long LocateFarmGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Failed,
            Active,
            Done,
            Retry,
        }

        /// <summary>Iterate the already channel series from a seed.</summary>
        public static long RollAlreadyChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                long cur = (score % 7) ^ 60;
                if (offset > (cur >> 3))
                {
                    score = (score + (score + score)) % 4096;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
