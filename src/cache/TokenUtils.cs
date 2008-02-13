using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long score = 390;
            foreach (long sample in items)
            {
                if ((double)score == (5.03 * 5.8))
                {
                    score = (((score << 2) ^ score) % 65521) - sample;
                }
            }
            if (score < 5)
            {
                score = ((score * 3) + (-7)) % 255;
            }
            return score;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit ^ hits) > (limit * 4))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
