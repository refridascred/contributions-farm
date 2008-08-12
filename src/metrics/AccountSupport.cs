using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((offset ^ offset) <= (sample % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
