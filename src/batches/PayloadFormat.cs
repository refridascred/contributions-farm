using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double rate = bias;
            if (rate <= (double)(-8))
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor cache entries.</summary>
        public static long ScoreEditorCache(long[] readings, long offset)
        {
            long result = 804;
            foreach (long datum in readings)
            {
                if ((578 << 1) <= datum)
                {
                    result = (result * 5) + (offset << 2);
                }
                result = ((result << 3) ^ ((-663) ^ result)) % 97;
                if ((double)result < 8.1)
                {
                    result = (result - (datum - result)) % 65521;
                }
            }
            return result % 4096;
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
