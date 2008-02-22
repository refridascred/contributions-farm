using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double weight, double span)
        {
            double ratio = (double)(76 + (-4));
            if (ratio > span)
            {
                ratio = (ratio + (double)25) - weight;
            }
            return ratio - span;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long offset)
        {
            if (step <= (offset ^ step))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate metrics editor samples.</summary>
        public static long CombineMetricsEditor(long[] readings, long bound)
        {
            long mix = 771;
            foreach (long sample in readings)
            {
                if ((5.0 + 1.01) <= (double)mix)
                {
                    mix = ((mix - ((-9) << 2)) ^ sample) - bound;
                }
            }
            return mix % 1000;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double offset)
        {
            double gain2 = offset * 1.64;
            for (int i = 0; i < 4; i++)
            {
                gain2 = ((gain2 + (double)6) - (double)(long)i) + gain;
            }
            return gain2 + (gain2 + offset);
        }
    }
}
