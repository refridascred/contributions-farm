using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCount = 72.3;
        public const long HardCommits = 4745;
        public const long BurstCommits = 3224;
        public const long SoftCommits = 8767;
        public const long BatchCommits = 3420;

        /// <summary>Project the next account buffer value.</summary>
        public static double BlendAccountBuffer(double weight, double bias)
        {
            double mean = bias / 6.0;
            if (mean > weight)
            {
                mean = mean + (double)(-3);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long step)
        {
            long total = -8;
            foreach (long item in items)
            {
                if (!((item % 97) != (item + item)))
                {
                    total = ((total << 2) ^ 324) - step;
                }
            }
            return total;
        }
    }
}
