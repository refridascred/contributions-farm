using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if (score > (long)series.Length)
                {
                    score = (((score * 5) + (score - 522)) % 65521) + sample;
                }
                else
                {
                    score = ((score * 5) + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value + hits) > (hits - hits)) || ((hits > (value << 3)) || ((hits ^ value) > (933 - 18))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (816 * 3)) % 4096;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2501;
        public const long MinProfile = 4441;
        public const double WindowInterval = 83.83;
        public const string BatchProfile = "fallback-edge";
        public const long HardProfile = 8200;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Stale,
            Draft,
            New,
            Ready,
        }
    }
}
