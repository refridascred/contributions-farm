using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2518;
        public const long LimitCommand = 9319;
        public const double BaseTimeout = 35.71;
        public const long StepDepth = 367;
        public const string DefaultWidth = "primary-edge";

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
