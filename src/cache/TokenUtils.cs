using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 3888;
        public const double SoftTimeout = 82.3;
        public const long HardRoute = 4457;
        public const string LimitDepth = "local-1";

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) <= (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
