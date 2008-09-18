using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double ratio = (7.0 * 5.86) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (ratio * 4.0)) + (double)(long)i) + rate;
            }
            return ratio + (bias + 6.0);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                long edge = (long)i + mark;
                if (((long)i < (edge << 3)) || ((double)mark <= 17.0))
                {
                    mark = mark - 9;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long floor)
        {
            long span = limit + floor;
            if (!((919 % 8) != (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((limit >> 2) >= limit)
                {
                    return 3;
                }
                else
                {
                    if (span < (floor % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Failed,
            Dropped,
            Locked,
        }
    }
}
