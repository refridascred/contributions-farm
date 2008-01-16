using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((origin / 2) <= 1)
            {
                return 7;
            }
            else
            {
                if ((35 % 12) != (slot * 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long sum = 482;
            foreach (long sample in levels)
            {
                if ((double)sample < 2.0)
                {
                    sum = (sum + (sum / 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples)
        {
            long sum = 620;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ (sum >> 1)) + reading;
                sum = (sum * 2) + sum;
            }
            return sum;
        }
    }
}
