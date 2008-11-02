using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of cluster session readings.</summary>
        public static long MatchClusterSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Idle,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items, long seed)
        {
            long state = 88;
            foreach (long entry in items)
            {
                state = (((state - (state << 1)) % 4096) ^ entry) - seed;
                state = (state + (state * 4)) % 65521;
            }
            if (state > 83)
            {
                state = (state + 43) % 65521;
            }
            return state % 1000;
        }
    }
}
