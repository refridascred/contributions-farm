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

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            Ready,
            Paused,
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
