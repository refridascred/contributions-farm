using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 5927;
        public const long BaseAccount = 2596;
        public const double MaxBudget = 70.18;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits - item) > hits) || ((double)item < 9.0))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
