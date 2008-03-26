using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((839 - count) == (count & 7))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long MeasureMetricClusterHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((sample << 2) >= 307) && (count < (origin << 1))) || ((61 >> 4) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
