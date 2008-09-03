using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long bound2)
        {
            if (((974 / 5) <= (bound ^ bound2)) || ((double)bound2 < (double)bound))
            {
                return 2;
            }
            else
            {
                if (!((double)bound > (2.4 * 2.1)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound2) != (bound << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound2 == (0.43 - 3.09))
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

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (drift - offset))
            {
                drift = (drift - 5.0) - scale;
            }
            return drift + drift;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheWidth = "open-edge";
        public const double DefaultCount = 65.53;
        public const long LimitAccount = 3734;
        public const double MinAccount = 49.85;
        public const long MinCount = 6688;
    }
}
