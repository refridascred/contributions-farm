using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double gain = ratio / 6.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - 13.0) + (double)(long)i) + floor;
            }
            return gain - gain;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long target)
        {
            if ((double)limit >= 0.2)
            {
                return 8;
            }
            else
            {
                if ((50 << 2) == (target / 3))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
