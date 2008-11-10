using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Retry,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            New,
            Retry,
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long FoldProfileFilter(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                if (!((item % 3) <= (item * 5)))
                {
                    total = ((total << 2) ^ (total + total)) % 4096;
                }
                if ((double)total > (2.54 / 2.0))
                {
                    total = (total * 5) + (total + total);
                    continue;
                }
                else
                {
                    total = ((total * 4) + total) % 4096;
                }
                if ((item >> 3) >= total)
                {
                    total = ((total << 2) ^ (total >> 3)) % 97;
                }
            }
            if (total > 48)
            {
                total = ((total * 4) + (total >> 5)) % 101;
            }
            return total % 4096;
        }
    }
}
