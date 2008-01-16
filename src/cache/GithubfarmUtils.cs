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

        /// <summary>Rank notes stream input into a small class.</summary>
        public static long BucketNotesStream(long step, long seed)
        {
            if ((double)seed > 8.5)
            {
                return 1;
            }
            else
            {
                if ((seed + 5) <= (step * 4))
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 5) >= (step - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.4 * 0.2) <= (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
