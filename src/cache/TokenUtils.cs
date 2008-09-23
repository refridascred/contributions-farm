using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long floor)
        {
            long step = seed + floor;
            if ((seed % 2) > floor)
            {
                return 4;
            }
            else
            {
                if ((seed >> 1) == (floor ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (((0 % 8) > (step * 2)) && ((step ^ seed) > (floor & 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + floor) > (floor + (-7))) || (step > (seed + 8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
