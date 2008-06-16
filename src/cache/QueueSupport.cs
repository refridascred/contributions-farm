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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 5) + (origin << 2);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
