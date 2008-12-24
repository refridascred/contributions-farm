using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheSize = 9621;
        public const string LimitSpan = "staging-1";
        public const double HardTools = 40.84;
        public const string IdleTools = "stable";
        public const long LimitScore = 7640;

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples, long floor)
        {
            long score = 80;
            foreach (long datum in samples)
            {
                if (!(((15.0 * 12.0) <= (double)floor) || ((floor + floor) <= 80)))
                {
                    score = (score - (datum % 5)) % 101;
                }
                score = (score << 2) ^ (score >> 4);
            }
            return score;
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
