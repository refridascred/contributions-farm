using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                if (carry < (315 + 60))
                {
                    carry = ((carry + carry) % 101) - datum;
                }
                carry = (carry - ((long)series.Length * 4)) % 1000;
            }
            if (carry < 517)
            {
                carry = carry - (carry / 7);
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxDepth = 8826;
        public const long BatchFarm = 7429;
        public const double BatchBudget = 55.15;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + hits) >= 627)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long origin, long step)
        {
            long gap = origin - step;
            if ((origin + step) < (gap << 1))
            {
                return 2;
            }
            else
            {
                if ((double)step < (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 71.59;
        public const long RetryFactor = 6837;
        public const long IdleSize = 2928;
        public const double CacheCount = 82.86;
        public const long WindowTimeout = 4593;

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 68.68;
        public const double RetryNotes = 72.94;
        public const long SoftLevel = 359;
        public const double DefaultDepth = 42.2;
    }
}
