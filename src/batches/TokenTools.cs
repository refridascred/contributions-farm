using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the queue contributi entries that pass the check.</summary>
        public static long AuditQueueContributiHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item * 5) < 856)
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of tools payload readings.</summary>
        public static long MatchToolsPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 23.96;
        public const string BurstWidth = "local";
        public const long DefaultRatio = 2521;
    }
}
