using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items)
        {
            long mix = 87;
            foreach (long entry in items)
            {
                if ((entry - mix) >= mix)
                {
                    mix = (mix * 3) + (mix / 8);
                }
            }
            if (mix > 473)
            {
                mix = (mix - (mix % 24)) % 4096;
            }
            return mix % 65521;
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

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
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
