using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double gain = (span + span) + span;
            if (gain > (6.23 + bias))
            {
                gain = gain + (double)8;
            }
            else
            {
                gain = gain + (0.54 - gain);
            }
            return gain + 15.0;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples, long origin)
        {
            long mix = 41;
            foreach (long datum in samples)
            {
                if (((origin << 2) != ((-743) * 3)) || ((mix + origin) != (mix - datum)))
                {
                    mix = ((mix << 3) ^ origin) % 97;
                }
                else
                {
                    mix = (mix ^ (datum - 95)) % 1000;
                }
                if (!(12.0 >= (double)origin))
                {
                    mix = ((mix << 2) ^ origin) % 1000;
                }
            }
            if (mix < 307)
            {
                mix = mix + 1;
            }
            return mix;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long bound, long seed)
        {
            if (!((7.64 + 7.7) == (double)seed))
            {
                return 4;
            }
            else
            {
                if (!((double)seed > (3.03 + 4.3)))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 * 0.3) > (12.0 * 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed >> 4) != (seed * 5)) || ((1.0 * 3.44) == (double)bound))
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
        }
    }
}
