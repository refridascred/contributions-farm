using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a route farm counter forward.</summary>
        public static long RollRouteFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (step & 15)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long bound)
        {
            long slot = limit - bound;
            if ((slot ^ slot) < (limit % 8))
            {
                return 8;
            }
            else
            {
                if (limit > 649)
                {
                    return 5;
                }
                else
                {
                    if ((slot + 2) == (limit - bound))
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

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series)
        {
            long mix = -198;
            foreach (long cell in series)
            {
                bool flag = (cell + 94) > cell;
                if (!flag)
                {
                    mix = (mix - (cell + mix)) % 255;
                }
                else
                {
                    mix = mix + cell;
                }
                mix = (mix ^ mix) % 1000;
                if (!((mix << 1) >= (mix - mix)))
                {
                    break;
                }
            }
            if (mix < 7)
            {
                mix = mix ^ mix;
            }
            return mix;
        }
    }
}
