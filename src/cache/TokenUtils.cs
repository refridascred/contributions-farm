using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next entry schema value.</summary>
        public static double ScaleEntrySchema(double rate, double offset)
        {
            double weight = offset * 9.5;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)(long)i) - rate;
            }
            return weight + weight;
        }

        /// <summary>Audit buffer payload readings against a rule.</summary>
        public static long CountBufferPayloadHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((20.0 * 7.87) > (double)limit) || (limit >= (limit + entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum % 64) > hits)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
