using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats channel value.</summary>
        public static double ScaleStatsChannel(double gain, double span)
        {
            double ratio = gain;
            if (ratio < ratio)
            {
                ratio = (ratio - gain) - span;
            }
            else
            {
                ratio = ratio + 14.0;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (gain / 5.0);
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long origin)
        {
            long bound = target ^ origin;
            if (((target & 63) < (964 * 3)) || ((double)target > (4.76 + 8.66)))
            {
                return 4;
            }
            else
            {
                if ((origin + bound) == (target + origin))
                {
                    return 5;
                }
                else
                {
                    if ((target >> 5) > (557 * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a notes cluster pair into a bucket.</summary>
        public static long RankNotesCluster(long seed, long bound)
        {
            if (!(4.3 > (double)seed))
            {
                return 4;
            }
            else
            {
                if ((bound > seed) || ((31 % 7) > (bound + bound)))
                {
                    return 6;
                }
                else
                {
                    if ((6.8 / 3.0) >= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long seed)
        {
            if ((double)seed != (7.9 + 0.97))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) != (6 << 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
