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

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
