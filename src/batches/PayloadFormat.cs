using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - matches) < (sample / 6))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = (scale - (5.9 + 6.2)) - offset;
            }
            return scale + scale;
        }

        /// <summary>Count batches metric pairs that satisfy a relation.</summary>
        public static long CompareBatchesMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double bias2 = (double)(97 + 184);
            if (bias2 <= (double)1)
            {
                bias2 = bias2 + (bias2 / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (gain * 3.6);
        }
    }
}
