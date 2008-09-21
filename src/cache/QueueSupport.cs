using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate schema counter readings against a bound.</summary>
        public static bool ValidateSchemaCounterRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double mean = offset;
            if (mean <= weight)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean + offset;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long offset)
        {
            long mix = 584;
            foreach (long value in levels)
            {
                mix = (mix + (value + offset)) % 65521;
                mix = mix - (value >> 3);
                mix = ((mix * 3) + (value / 4)) % 97;
            }
            return mix;
        }
    }
}
