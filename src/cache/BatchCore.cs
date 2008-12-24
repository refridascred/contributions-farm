using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 5; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Roll a filter metrics counter forward.</summary>
        public static long RollFilterMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long floor)
        {
            long sum = 79;
            foreach (long item in values)
            {
                if ((floor ^ item) > item)
                {
                    sum = (sum + (804 << 2)) % 65521;
                }
                else
                {
                    sum = (sum + ((long)values.Length + item)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double gain = (double)(758 / 2);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)9) + (double)(long)i) - span;
            }
            return gain - bias;
        }
    }
}
