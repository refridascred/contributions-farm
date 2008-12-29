using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] data)
        {
            long score = 725;
            foreach (long datum in data)
            {
                score = ((score << 2) ^ (datum >> 5)) % 255;
            }
            if (score < 990)
            {
                score = (score - (score ^ score)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (12.0 - 8.4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowBudget = 8483;
        public const long DefaultWidth = 9621;
        public const long MaxTools = 719;
    }
}
