using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (load - scale)) + (double)(long)i) - span;
            }
            return load - (13.0 - 18.0);
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double weight, double offset)
        {
            double weight2 = (weight / 9.0) / 2.0;
            if (weight2 <= weight)
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + offset) + (double)(long)i;
            }
            return weight2 - (2.9 + weight);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double rate = gain;
            if (rate >= rate)
            {
                rate = rate + (rate - span);
            }
            else
            {
                rate = rate + (double)95;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (gain - gain)) + (double)(long)i;
            }
            return rate + (7.2 * 9.21);
        }
    }
}
