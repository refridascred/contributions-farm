using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 5) == (sample * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry cache reading.</summary>
        public static double BlendEntryCache(double weight, double bias)
        {
            double rate = (double)6;
            if (rate <= (weight - bias))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (bias + bias);
        }

        /// <summary>Check that every layout queue entry stays within the limit.</summary>
        public static bool ValidateLayoutQueueRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
