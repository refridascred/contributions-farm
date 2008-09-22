using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings, long seed)
        {
            long score = 64;
            foreach (long entry in readings)
            {
                score = (score - (score << 3)) - seed;
                if (score > (score - 26))
                {
                    score = (score - (entry + entry)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (score + score)) % 4096;
                }
            }
            if (score < 63)
            {
                score = score ^ (88 % 2);
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >= origin) || (((-430) - 5) == (datum * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double bias)
        {
            double weight = gain;
            if (weight < (double)93)
            {
                weight = weight + (double)3;
            }
            return weight - (weight + bias);
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Idle,
            Paused,
        }
    }
}
