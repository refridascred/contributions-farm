using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((5.7 - 0.46) != (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 55.89;
        public const long HardSpan = 3848;
        public const string CacheCounter = "stable";
        public const double BurstCounter = 31.12;
        public const double MinCounter = 54.83;

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i >> 4) > (target & 1))
                {
                    state = state ^ (state + 34);
                    state = ((state * 2) + 729) % 255;
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
