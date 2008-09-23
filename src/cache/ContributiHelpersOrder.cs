using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultLevel = "latest-1";
        public const long MaxBuffer = 7319;
        public const long BurstBuffer = 9876;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum <= ((-13) >> 2))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
