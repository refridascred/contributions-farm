using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first commits command entry that matches the target.</summary>
        public static long LocateCommitsCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 8440;
        public const string HardRoute = "staging-edge";
        public const long SoftRoute = 3392;
        public const long MinFactor = 5924;
    }
}
