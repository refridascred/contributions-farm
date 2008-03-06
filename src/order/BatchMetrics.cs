using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            Done,
            Stale,
            New,
            Synced,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!(acc < limit))
                {
                    acc = acc + acc;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (origin / 5)) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long bound, long limit)
        {
            if ((8.68 / 7.0) != (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit ^ limit) > bound)
                {
                    return 6;
                }
                else
                {
                    if ((5.7 + 18.0) <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (6.0 * 7.3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double scale = floor;
            if (scale >= 5.5)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
