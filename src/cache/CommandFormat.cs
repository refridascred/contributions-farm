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

        /// <summary>Iterate the metrics checks series from a seed.</summary>
        public static long StepMetricsChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + seed) % 65521) + (long)i2;
                }
                if (seed < (seed + seed))
                {
                    acc = (acc * 5) + (seed << 3);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
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
