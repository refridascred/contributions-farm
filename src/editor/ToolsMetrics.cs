using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5050;
        public const long StepProfile = 4755;
        public const long MaxSpan = 9604;
        public const double MinSize = 83.2;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double scale = (double)((-69) - 348);
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale + (16.0 * 6.11)) + (double)(long)i) - rate) + span;
            }
            return scale - (scale / 6.0);
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
        }
    }
}
