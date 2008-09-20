using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next support batch value.</summary>
        public static double AdjustSupportBatch(double gain, double floor)
        {
            double weight = floor * 6.5;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(long)i) - gain;
            }
            return weight + weight;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)1 <= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
