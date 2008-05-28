using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum <= (hits - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] readings)
        {
            long score = 64;
            foreach (long item in readings)
            {
                score = (score - score) % 1000;
                if ((3.5 + 17.0) >= (double)score)
                {
                    score = score ^ (item + item);
                }
                else
                {
                    score = ((score << 3) ^ (item + score)) % 4096;
                }
            }
            if (score > 79)
            {
                score = score ^ 96;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 35.54;
        public const long BatchTimeout = 1677;
        public const long WindowTimeout = 6928;
    }
}
