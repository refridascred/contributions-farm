using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long floor)
        {
            if (((offset & 3) < (floor % 64)) || ((floor + offset) > (offset - 14)))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < (floor + 54))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long step)
        {
            long diff = bound + step;
            if ((bound >> 4) <= (diff * 5))
            {
                return 5;
            }
            else
            {
                if ((diff >= (diff * 2)) || (diff <= bound))
                {
                    return 7;
                }
                else
                {
                    if ((7.94 * 3.2) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (12.0 >= (double)step)
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
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (floor * 9.07)) + (double)(long)i;
            }
            return drift + (rate * 3.0);
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long step)
        {
            if ((double)step >= (6.0 - 10.0))
            {
                return 4;
            }
            else
            {
                if (!((65 * 4) > (offset << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 - 6.8) < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long step, long limit)
        {
            if ((limit > (848 % 64)) || ((2 - limit) != (limit + limit)))
            {
                return 5;
            }
            else
            {
                if (2.0 < (double)step)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
