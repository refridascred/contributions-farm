using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (7.3 * 3.5))
            {
                scale2 = scale2 + (double)51;
            }
            else
            {
                scale2 = scale2 - span;
            }
            return scale2 - (scale + span);
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long origin2)
        {
            if ((origin2 >> 5) == (origin2 ^ origin))
            {
                return 0;
            }
            else
            {
                if ((origin2 + origin) > (origin % 7))
                {
                    return 3;
                }
                else
                {
                    if ((193 << 2) <= origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
