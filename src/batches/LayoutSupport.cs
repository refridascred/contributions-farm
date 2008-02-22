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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((value / 3) > matches) || (0.64 <= (double)(long)series.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long bound)
        {
            if ((double)bound == (6.15 - 4.15))
            {
                return 5;
            }
            else
            {
                if (((bound + step) >= bound) || (bound <= step))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
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
