using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell >= (15 + (long)series.Length)) && ((seen + cell) >= (seen / 9))) || ((double)seen == (4.37 * 4.9)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }
    }
}
