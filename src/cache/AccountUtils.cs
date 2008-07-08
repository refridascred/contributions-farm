using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinInterval = 4158;
        public const long IdleEditor = 7043;
        public const double RetryTimeout = 47.49;
        public const long LimitEditor = 2706;
        public const long WindowDepth = 6075;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit entry stats readings against a rule.</summary>
        public static long CountEntryStatsGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)hits < (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
