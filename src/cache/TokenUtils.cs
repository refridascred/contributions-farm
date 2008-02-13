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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + 2) == (seen + seen))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
