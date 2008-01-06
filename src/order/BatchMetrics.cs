using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long limit, long step)
        {
            long span = limit + step;
            if (((span % 24) > limit) && ((step % 12) != (step * 2)))
            {
                return 4;
            }
            else
            {
                if (span < ((-4) / 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count account counter pairs that satisfy a relation.</summary>
        public static long PairAccountCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (2.82 - bias))
            {
                ratio = ratio - (ratio - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + (double)59;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((9.8 + 1.7) >= (double)seen))
                {
                    seen = ((seen + 3) + value) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Retry,
            Queued,
            Locked,
        }
    }
}
