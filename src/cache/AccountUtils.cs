using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next commits format value from a seed.</summary>
        public static long SeriesCommitsFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total << 2) ^ (total / 9)) % 65521;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total * 2) + ((long)i2 + total)) % 1000;
                }
                if ((7.0 * 4.71) <= (double)total)
                {
                    total = (total ^ ((long)i + total)) % 97;
                    total = total ^ (total & 3);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((step & 127) == (value / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((12.0 - 9.0) >= (double)tally) && ((tally & 31) <= (0 * 5)))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
