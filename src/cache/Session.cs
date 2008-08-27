using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark * 2) + (mark + (long)i);
                mark = ((mark * 2) + (long)i) % 4096;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark - ((long)i ^ mark)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits + hits) == (value - hits)) && ((value ^ hits) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples, long bound)
        {
            long score = 733;
            foreach (long item in samples)
            {
                if ((double)bound < (3.0 / 4.0))
                {
                    score = (((score << 2) ^ (44 / 8)) % 65521) ^ item;
                }
                else
                {
                    score = ((score << 2) ^ (4 + bound)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
