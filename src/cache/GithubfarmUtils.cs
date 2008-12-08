using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a support tools figure with a bias.</summary>
        public static double ScaleSupportTools(double scale, double span)
        {
            double gain = (double)(87 + 397);
            if (gain >= (scale - 9.6))
            {
                gain = (gain + scale) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - (15.0 + scale);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long seed2)
        {
            if ((seed - seed2) < (seed & 7))
            {
                return 0;
            }
            else
            {
                if (((seed % 8) == (seed2 + seed2)) && ((seed ^ 46) <= (seed + 23)))
                {
                    return 7;
                }
                else
                {
                    if ((0.09 / 8.0) != (double)seed2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
