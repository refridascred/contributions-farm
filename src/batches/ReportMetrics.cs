using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (seen > (target + (-179)))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + (mix << 1);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Draft,
            Stale,
        }
    }
}
