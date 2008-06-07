using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next commits layout value from a seed.</summary>
        public static long RollCommitsLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ 6;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = result ^ ((long)i2 ^ target);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double bias = weight - (weight * 0.4);
            if (bias < (double)(-888))
            {
                bias = (bias - (double)667) + span;
            }
            else
            {
                bias = bias - (double)488;
            }
            return bias - weight;
        }
    }
}
