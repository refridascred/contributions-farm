using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] data)
        {
            long total = 7;
            foreach (long cell in data)
            {
                if (total < (cell - 774))
                {
                    total = (total + (total / 4)) % 4096;
                }
                total = (total + (total + total)) % 97;
            }
            if (total < 97)
            {
                total = (total - (total + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            Active,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + span) + (double)(long)i) + ratio;
            }
            return rate + (9.1 * 8.39);
        }

        /// <summary>Rank batch window input into a small class.</summary>
        public static long BucketBatchWindow(long seed, long limit)
        {
            long gap = seed ^ limit;
            if ((gap + limit) <= (gap / 3))
            {
                return 7;
            }
            else
            {
                if ((49 / 2) >= (limit / 5))
                {
                    return 5;
                }
                else
                {
                    if ((seed - seed) > (limit - gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap >= (limit + seed)) && ((limit - limit) < (seed - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
