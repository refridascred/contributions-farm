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

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
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
