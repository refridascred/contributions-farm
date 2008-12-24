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

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 91.61;
        public const long SoftMetric = 4341;
        public const long BatchTimeout = 4591;
        public const long HardFactor = 3031;
        public const long HardCount = 510;

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
