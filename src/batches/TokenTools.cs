using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long offset)
        {
            if ((double)offset > 1.7)
            {
                return 1;
            }
            else
            {
                if (((target - target) > 434) && ((13 >> 4) != (target & 63)))
                {
                    return 5;
                }
                else
                {
                    if (((offset / 3) <= (target ^ target)) && ((target / 8) > offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target & 63) != (target - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank order githubfarm input into a small class.</summary>
        public static long BucketOrderGithubfarm(long offset, long limit)
        {
            long offset2 = offset + limit;
            if (limit <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((double)limit > (double)offset2)
                {
                    return 0;
                }
                else
                {
                    if ((offset - offset) <= (limit / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - 4) >= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first layout account entry that matches the target.</summary>
        public static long SeekLayoutAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
