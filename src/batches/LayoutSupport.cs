using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double bias)
        {
            double scale = gain;
            return (scale - gain) + bias;
        }

        /// <summary>Classify a profile route pair into a bucket.</summary>
        public static long ClassifyProfileRoute(long step, long target)
        {
            if (((step << 1) < 52) && ((8 + step) <= (96 * 4)))
            {
                return 8;
            }
            else
            {
                if (((target & 3) <= (-4)) && (step > (target >> 3)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank command farm input into a small class.</summary>
        public static long GradeCommandFarm(long seed, long bound)
        {
            if ((0 ^ bound) > seed)
            {
                return 8;
            }
            else
            {
                if ((bound + seed) < bound)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
