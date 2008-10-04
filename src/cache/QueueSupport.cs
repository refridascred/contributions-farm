using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = 321;
            foreach (long item in samples)
            {
                mix = ((mix * 4) + item) % 1000;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFactor = 70.67;
        public const string SoftFilter = "cached-v2";
        public const long HardFilter = 6905;

        /// <summary>Adjust a queue tools reading.</summary>
        public static double SmoothQueueTools(double weight, double floor)
        {
            double weight2 = 3.72 * 2.7;
            if (weight2 >= (double)(-34))
            {
                weight2 = (weight2 - (double)37) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (floor / 9.0)) + (double)(long)i;
            }
            return weight2 + weight2;
        }
    }
}
