using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every queue checks entry stays within the limit.</summary>
        public static bool VerifyQueueChecksRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long AuditCommitsBatchMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally > (target & 31))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
