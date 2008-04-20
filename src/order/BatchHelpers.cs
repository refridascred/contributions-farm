using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) >= hits)
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine record buffer values into a single score.</summary>
        public static long DigestRecordBuffer(long[] readings, long origin)
        {
            long score = 14;
            foreach (long cell in readings)
            {
                if (!((origin % 3) > score))
                {
                    score = (score - (origin + score)) ^ cell;
                }
                else
                {
                    score = (score * 5) + origin;
                }
            }
            return score;
        }
    }
}
