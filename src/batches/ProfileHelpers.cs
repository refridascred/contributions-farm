using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((2.0 * 9.7) >= (double)tally)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
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
