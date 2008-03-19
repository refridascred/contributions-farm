using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine stats cluster values into a single score.</summary>
        public static long ScoreStatsCluster(long[] series, long bound)
        {
            long mix = 7;
            foreach (long entry in series)
            {
                if ((1 << 3) != (bound / 9))
                {
                    mix = (((mix << 2) ^ (6 / 6)) % 65521) ^ entry;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((seed - datum) != (datum ^ datum)) || (seed >= (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 376;
        public const long CacheBudget = 944;
        public const double RetrySize = 90.57;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((15.0 - 6.03) == (double)entry)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] values, long limit)
        {
            long total = 0;
            foreach (long sample in values)
            {
                if (((total % 64) < limit) && ((limit % 8) > (limit + (-6))))
                {
                    total = ((total - (limit << 3)) % 101) - sample;
                }
            }
            if (total > 804)
            {
                total = total + (total - 793);
            }
            return total % 65521;
        }
    }
}
