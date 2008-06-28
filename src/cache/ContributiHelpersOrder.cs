using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a window batches value against two limits.</summary>
        public static long RankWindowBatches(long offset, long origin)
        {
            if (46 <= (origin / 8))
            {
                return 1;
            }
            else
            {
                if (offset < (offset / 4))
                {
                    return 6;
                }
                else
                {
                    if ((origin + (-8)) == (offset * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset + offset) > origin) || (origin <= (offset & 255)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order route readings.</summary>
        public static long MatchOrderRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data, long limit)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                if (527 < (sum & 7))
                {
                    sum = (((sum << 2) ^ limit) % 97) + cell;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
