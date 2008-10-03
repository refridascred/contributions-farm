using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((3 >> 2) < bound)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long RankEntryAccount(long target, long target2)
        {
            long bound = target - target2;
            if (148 < (target2 * 4))
            {
                return 0;
            }
            else
            {
                if ((16 + 60) <= target)
                {
                    return 8;
                }
                else
                {
                    if ((bound - target) <= (bound + 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (7 >= (target + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Paused,
            Ready,
            Active,
            Synced,
        }
    }
}
