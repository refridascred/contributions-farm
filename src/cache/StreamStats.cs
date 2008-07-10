using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long limit)
        {
            if ((bound << 3) <= bound)
            {
                return 1;
            }
            else
            {
                if ((46 % 60) <= (16 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 63) <= (limit + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (57 + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item > (1.0 + 20.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((diff + seed) > ((-1) << 2))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
