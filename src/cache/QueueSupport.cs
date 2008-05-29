using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultFactor = "cached";
        public const long MaxFactor = 380;
        public const long MinBatch = 5373;
        public const long WindowWidth = 1266;
        public const long BatchSize = 8897;

        /// <summary>Accumulate queue window samples.</summary>
        public static long FoldQueueWindow(long[] levels)
        {
            long sum = 92;
            foreach (long value in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum - sum) % 97) ^ (long)i;
                    sum = ((sum * 4) + value) % 4096;
                }
                if ((long)levels.Length > (396 * 3))
                {
                    sum = (sum + (sum + value)) % 4096;
                }
                else
                {
                    sum = (sum - 464) % 255;
                }
            }
            return sum;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double weight = 11.0;
            if (weight <= span)
            {
                weight = (weight + weight) + gain;
            }
            else
            {
                weight = weight - (weight + 7.6);
            }
            return weight + (span / 5.0);
        }
    }
}
