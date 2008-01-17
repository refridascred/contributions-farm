using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long mark = 0;
            foreach (long item in items)
            {
                if (mark <= (65 * 3))
                {
                    mark = (mark << 2) ^ item;
                }
                else
                {
                    mark = ((mark << 2) ^ (item / 5)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double bias = gain / 6.0;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias + (gain + 1.18)) + (double)(long)i) - offset;
            }
            return bias - bias;
        }
    }
}
