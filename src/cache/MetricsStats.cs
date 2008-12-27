using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every checks stream entry stays within the limit.</summary>
        public static bool VerifyChecksStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long seed)
        {
            if ((double)floor >= 1.91)
            {
                return 1;
            }
            else
            {
                if (76 > (46 + seed))
                {
                    return 4;
                }
                else
                {
                    if (((seed - 717) != (seed << 3)) && ((double)seed > (double)1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double mean = gain;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (gain * 6.0)) + (double)(long)i) + bias;
            }
            return mean + (gain / 5.0);
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Active,
            Closed,
        }
    }
}
