using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long step)
        {
            long total = 520;
            foreach (long value in samples)
            {
                if (!((511 ^ step) >= (value + total)))
                {
                    total = (total - (84 + step)) % 101;
                }
            }
            return total;
        }

        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long RollBufferGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 3) ^ (778 + score)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of payload record readings.</summary>
        public static long ScorePayloadRecord(long[] items, long floor)
        {
            long sum = 9;
            foreach (long entry in items)
            {
                sum = (sum + (25 - entry)) - floor;
            }
            return sum % 65521;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long seed)
        {
            long diff = bound + seed;
            if ((bound % 5) > diff)
            {
                return 4;
            }
            else
            {
                if ((double)bound > (4.0 * 3.91))
                {
                    return 8;
                }
                else
                {
                    if (diff > (diff - diff))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((diff - diff) >= seed) && ((diff / 6) == (bound / 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples, long step)
        {
            long sum = 471;
            foreach (long datum in samples)
            {
                sum = (((sum << 2) ^ (sum & 255)) + datum) - step;
            }
            return sum;
        }
    }
}
