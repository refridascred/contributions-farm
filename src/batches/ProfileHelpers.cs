using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 798;
        public const long LimitAlready = 5967;
        public const string IdleAlready = "latest-edge";
        public const string BatchAlready = "stable-1";
        public const string BatchInterval = "alpha-edge";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long seed2)
        {
            long edge = seed ^ seed2;
            if (((-464) * 5) <= seed2)
            {
                return 5;
            }
            else
            {
                if (((double)edge == (double)7) && (6 > seed2))
                {
                    return 2;
                }
                else
                {
                    if (edge > (seed ^ 78))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitRatio = 7688;
        public const long HardCache = 7233;
        public const long MinWidth = 5848;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double load = (double)(514 + 722);
            if (load <= (weight / 8.0))
            {
                load = load + (offset - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)(-464)) + (double)(long)i;
            }
            return load - (double)36;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long floor)
        {
            if (((837 << 2) == (bound - floor)) && ((floor - floor) > 0))
            {
                return 6;
            }
            else
            {
                if ((double)16 > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((bound << 3) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
