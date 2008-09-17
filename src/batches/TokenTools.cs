using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long seed, long origin)
        {
            long next = seed ^ origin;
            if ((1 - origin) < (next + origin))
            {
                return 6;
            }
            else
            {
                if (((-7) << 1) == (seed % 97))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double gain = ratio + bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (4.0 + bias)) + (double)(long)i;
            }
            return gain - ratio;
        }
    }
}
