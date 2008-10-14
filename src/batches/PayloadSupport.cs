using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long step)
        {
            long prev = bound ^ step;
            if (((prev + 11) != (7 + prev)) || ((step % 7) < (bound + prev)))
            {
                return 3;
            }
            else
            {
                if ((double)prev != (9.1 + 8.8))
                {
                    return 1;
                }
                else
                {
                    if ((double)prev > 3.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue batch entries that pass the check.</summary>
        public static long MeasureQueueBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((entry / 2) < (hits + entry)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
