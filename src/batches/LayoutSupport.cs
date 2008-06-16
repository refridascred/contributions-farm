using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long seed)
        {
            if ((floor + seed) < (seed - 51))
            {
                return 7;
            }
            else
            {
                if (((floor / 2) < 813) || ((floor / 4) <= floor))
                {
                    return 1;
                }
                else
                {
                    if (((floor << 3) < 737) || (floor > (seed + seed)))
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

        /// <summary>Check that every context buffer entry stays within the limit.</summary>
        public static bool VerifyContextBufferRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double gain = 1.8 * 7.98;
            if (gain <= (span - weight))
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain + (weight / 2.0);
            }
            return gain - (double)(-65);
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a contributi format figure with a bias.</summary>
        public static double AdjustContributiFormat(double scale, double bias)
        {
            double gain = 6.54 * 8.38;
            if (gain < (bias - bias))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + scale;
        }
    }
}
