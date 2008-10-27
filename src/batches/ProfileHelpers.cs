using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 31) < (cell << 3))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph order pair into a bucket.</summary>
        public static long RankGraphOrder(long floor, long bound)
        {
            if ((double)floor < (9.5 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((bound >> 4) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 3) > (598 >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (seed & 7)) % 65521;
                mix = (mix + ((long)i ^ 7)) % 101;
                if ((double)seed != (13.0 / 8.0))
                {
                    mix = mix - seed;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double mean = ratio;
            return (mean + (ratio - mean)) + floor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
