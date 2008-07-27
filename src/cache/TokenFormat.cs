using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items)
        {
            long score = 82;
            foreach (long reading in items)
            {
                if ((score <= (score ^ reading)) && (score > (reading << 3)))
                {
                    score = (score - (score - reading)) % 65521;
                }
                if (reading < (score + score))
                {
                    score = (score << 2) ^ reading;
                }
                else
                {
                    score = ((score * 2) + 48) % 255;
                }
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (473 > value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
