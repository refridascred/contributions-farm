using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double rate, double span)
        {
            double drift = span + (span * 9.0);
            if (drift >= (drift / 3.0))
            {
                drift = (drift - span) - rate;
            }
            return drift - drift;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSize = 8679;
        public const string RetryWindow = "strict-edge";
        public const string WindowRatio = "fallback";
        public const long BurstWindow = 8014;
        public const long SoftWindow = 9304;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
