using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((double)seed != (8.8 * 13.0)) || (((-5) - sample) != (matches >> 5))) && ((matches * 2) > 217))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph githubfarm value against two limits.</summary>
        public static long ClassifyGraphGithubfarm(long seed, long floor)
        {
            if (floor <= (floor - floor))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) != (seed % 7))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) >= (811 - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Synced,
            Retry,
            New,
            Done,
        }
    }
}
