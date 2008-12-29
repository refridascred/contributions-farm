using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a cache checks counter forward.</summary>
        public static long RollCacheChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if ((target * 4) < (target + score))
                {
                    score = (score + score) % 1000;
                    continue;
                }
                else
                {
                    score = score + (score % 16);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double floor)
        {
            double bias = 5.0;
            if (bias < (bias + 5.0))
            {
                bias = (bias - (double)(-55)) - floor;
            }
            else
            {
                bias = bias - (weight / 6.0);
            }
            return bias + (double)32;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
