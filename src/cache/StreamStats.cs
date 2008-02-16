using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long target)
        {
            if (((bound + bound) == (bound - 42)) || ((bound >> 5) > (bound + bound)))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) >= 32)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinInterval = 31.06;
        public const long BatchCounter = 709;
        public const string WindowCounter = "strict-v2";
        public const long SoftCounter = 2116;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((355 + count) > (count - count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double ratio = gain;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)(long)i) - bias;
            }
            return ratio - (ratio / 4.0);
        }
    }
}
