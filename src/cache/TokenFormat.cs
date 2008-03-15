using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count < (1.9 - 17.0))
                {
                    count = ((count + 1) ^ entry) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long origin)
        {
            long score = 614;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 3) ^ origin) % 4096) ^ (long)i;
                }
                score = (score ^ (value + score)) % 101;
            }
            if (score < 493)
            {
                score = (score ^ (12 / 9)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
