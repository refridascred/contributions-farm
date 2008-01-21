using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a stats githubfarm value against two limits.</summary>
        public static long GradeStatsGithubfarm(long origin, long bound)
        {
            long lane = origin + bound;
            if ((967 - lane) <= lane)
            {
                return 1;
            }
            else
            {
                if ((origin % 7) >= (bound + origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)lane <= 4.8)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= (lane * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long seed)
        {
            if ((2.21 * 4.0) < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((offset & 31) != (seed - 95))
                {
                    return 4;
                }
                else
                {
                    if ((offset + seed) >= (offset / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long floor, long seed)
        {
            long offset = floor + seed;
            if ((seed % 12) < 465)
            {
                return 2;
            }
            else
            {
                if ((floor / 8) > offset)
                {
                    return 0;
                }
                else
                {
                    if (seed >= (164 * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = 3.0;
            if (scale < (double)5)
            {
                scale = ((scale - (double)9) + weight) - span;
            }
            return scale - 1.7;
        }
    }
}
