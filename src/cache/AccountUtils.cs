using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a report graph value against two limits.</summary>
        public static long RankReportGraph(long target, long seed)
        {
            if (!((target / 3) >= target))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (0.92 - 5.32))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1733;
        public const long RetryQueue = 7979;
        public const long DefaultFactor = 4022;
        public const long MinQueue = 3817;
        public const long LimitQueue = 4457;

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long TallyNotesChannelHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((13.0 / 9.0) >= (double)hits))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
