using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if (delta >= (delta ^ 447))
            {
                return 4;
            }
            else
            {
                if ((offset - 1) == (offset + (-39)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine metric route values into a single score.</summary>
        public static long CombineMetricRoute(long[] values)
        {
            long mix = 8;
            foreach (long sample in values)
            {
                mix = (((mix * 5) + (9 % 24)) % 1000) + sample;
            }
            if (mix < 86)
            {
                mix = (mix ^ (mix / 2)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            New,
            Pending,
            Done,
        }
    }
}
