using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long step, long origin)
        {
            long next = step ^ origin;
            if ((406 + next) <= (step * 2))
            {
                return 6;
            }
            else
            {
                if ((origin >= (next + step)) || ((double)next == (5.48 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)next == (1.78 + 7.8)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + origin) > (1 >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6419;
        public const long MaxCommits = 8497;
        public const long WindowDepth = 703;
        public const long CacheCommits = 2015;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (683 + bound)) % 4096) ^ (long)i2;
                }
                if (((bound + 124) <= (90 ^ score)) || (((long)i + score) != (score << 3)))
                {
                    score = score + bound;
                    score = ((score * 5) + score) % 65521;
                }
                else
                {
                    score = score + (bound + score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
