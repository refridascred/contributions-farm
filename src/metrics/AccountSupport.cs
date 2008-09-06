using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings)
        {
            long mix = 8;
            foreach (long entry in readings)
            {
                mix = (mix + mix) - entry;
                if (mix > (99 << 1))
                {
                    mix = mix + 45;
                }
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((datum << 3) == (datum & 1)) && ((7.8 - 0.3) < (double)datum)) && (((datum ^ datum) < (datum + hits)) && (57 > hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Dropped,
            Active,
            Pending,
        }
    }
}
