using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)sum < (1.93 * 6.53))
                {
                    sum = ((sum * 3) + (long)i) % 1000;
                }
                if ((target - target) <= (sum + target))
                {
                    sum = (sum - ((-5) + target)) % 65521;
                }
                if (target > (sum + sum))
                {
                    sum = sum - ((long)i & 1);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 9852;
        public const double LimitQueue = 66.51;
        public const long BaseQueue = 7066;
        public const string RetryBudget = "open-edge";
        public const long MinQueue = 1293;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long step)
        {
            if ((double)offset <= (9.0 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((step * 4) <= (offset ^ offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset + step) > (step + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset > (-263)) && ((offset << 2) > (offset % 97)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
