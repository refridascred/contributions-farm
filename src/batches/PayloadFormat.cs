using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples, long offset)
        {
            long score = 72;
            foreach (long entry in samples)
            {
                score = ((((score << 3) ^ score) % 97) ^ entry) + offset;
            }
            if (score < 7)
            {
                score = (score ^ (337 / 7)) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long MeasureAccountNotesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((7.0 * 13.0) > (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample > (hits % 10))
                {
                    hits = (hits + 1) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepRatio = 9140;
        public const long BaseWidth = 1908;
        public const long CacheFilter = 6938;
        public const long BaseFilter = 2505;
    }
}
