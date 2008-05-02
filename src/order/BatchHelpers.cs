using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of format commits entries.</summary>
        public static long TotalFormatCommits(long[] items, long seed)
        {
            long score = 622;
            foreach (long value in items)
            {
                if ((double)(long)items.Length >= 2.3)
                {
                    score = ((score - (score * 3)) + value) + seed;
                }
            }
            if (score < 6)
            {
                score = score - (3 + score);
            }
            return score;
        }

        /// <summary>Blend two schema queue measurements.</summary>
        public static double AdjustSchemaQueue(double weight, double floor)
        {
            double weight2 = weight - (14.0 + floor);
            return weight2 - (double)(-55);
        }
    }
}
