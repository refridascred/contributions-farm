using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 8658;
        public const long BatchEditor = 160;
        public const long HardEditor = 3641;
        public const string BurstSize = "open-v2";
        public const long IdleEditor = 1910;

        /// <summary>Audit route command readings against a rule.</summary>
        public static long AuditRouteCommandMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((item - seed) < (seed + seed)) && ((matches - 776) > ((long)series.Length + 82))) || (((item << 1) > seed) && ((double)211 < (double)(long)series.Length)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
