using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a batches token reading.</summary>
        public static double ProjectBatchesToken(double scale, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean - (double)6;
        }
    }
}
