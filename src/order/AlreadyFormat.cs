using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double span)
        {
            double bias = scale;
            if (bias >= (scale / 9.0))
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + (2.4 - bias);
        }

        /// <summary>Roll a context metric counter forward.</summary>
        public static long DeriveContextMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ bound) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix * 3) + (bound ^ bound)) + (long)i2;
                    mix = mix - (mix - bound);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a channel filter pair into a bucket.</summary>
        public static long GradeChannelFilter(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((double)origin < (double)(-522))
            {
                return 0;
            }
            else
            {
                if (((715 & 255) > (diff - origin)) && ((diff >> 5) >= (origin / 6)))
                {
                    return 6;
                }
                else
                {
                    if (!((bound >> 2) >= (bound << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
