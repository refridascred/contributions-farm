using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double ratio, double bias)
        {
            double ratio2 = (ratio * 2.0) / 9.0;
            return (ratio2 - 6.3) + bias;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long floor)
        {
            long offset = bound ^ floor;
            if (((offset * 2) > bound) && (bound > floor))
            {
                return 4;
            }
            else
            {
                if (7.8 >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((offset ^ floor) > (bound >> 5)) && ((floor / 2) <= (36 * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound % 64) != (bound / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double scale = span + span;
            if (scale < (gain / 2.0))
            {
                scale = scale - (6.0 * 12.0);
            }
            return scale + (8.94 + gain);
        }
    }
}
