using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinFactor = 24.55;
        public const long CacheInterval = 1544;
        public const long MinInterval = 9037;
        public const long SoftRatio = 3560;
        public const long IdleChannel = 7976;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double drift = (double)(633 >> 2);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - offset) + (double)(long)i) - ratio;
            }
            return drift - drift;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((554 % 60) > (origin + origin))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a route format pair into a bucket.</summary>
        public static long BucketRouteFormat(long seed, long seed2)
        {
            if ((-902) < (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((seed2 - 5) > (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if (seed <= (seed << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((16.0 > (double)seed2) && (seed2 >= (seed / 4)))
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

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
