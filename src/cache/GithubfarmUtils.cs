using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long target)
        {
            if ((11.0 * 7.1) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((7.1 * 2.46) != (double)target))
                {
                    return 0;
                }
                else
                {
                    if (!((18.0 - 8.72) < (6.7 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound / 5) < (target >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit <= (sum + (long)i))
                {
                    sum = (sum + sum) % 255;
                    sum = sum ^ (sum + limit);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum + (sum + 959)) - (long)i2;
                }
                if (!((sum - sum) < limit))
                {
                    sum = ((sum * 2) + (sum & 31)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long origin)
        {
            long next = limit + origin;
            if ((origin ^ next) <= (next - limit))
            {
                return 7;
            }
            else
            {
                if ((15.0 / 2.0) >= (double)next)
                {
                    return 1;
                }
                else
                {
                    if ((limit & 31) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
