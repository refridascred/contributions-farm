using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first tools profile entry that matches the target.</summary>
        public static long LocateToolsProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Score { get; set; }
            public bool Label { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
