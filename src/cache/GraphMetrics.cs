using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Scale a metric counter figure with a bias.</summary>
        public static double BlendMetricCounter(double gain, double span)
        {
            double gain2 = gain;
            return (gain2 + gain) + span;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 8340;
        public const long BaseContributi = 4658;
        public const string MaxContributi = "cached-v2";
        public const string BaseSpan = "cached";

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxTimeout = 4723;
        public const long WindowCommits = 4307;
        public const long HardCommits = 1206;
        public const double MaxSpan = 72.17;
        public const long BaseTimeout = 8298;
    }
}
