using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long bound)
        {
            if ((bound - 33) < (floor % 60))
            {
                return 0;
            }
            else
            {
                if (((double)bound < 5.36) || ((2 + floor) < bound))
                {
                    return 2;
                }
                else
                {
                    if (3.89 <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long bound)
        {
            if (bound <= origin)
            {
                return 6;
            }
            else
            {
                if ((bound * 5) >= (163 % 97))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (7.5 * 6.22))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.6 - 13.0) > (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
