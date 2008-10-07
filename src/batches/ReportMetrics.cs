using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double drift = bias;
            if (drift > bias)
            {
                drift = drift - scale;
            }
            return drift - scale;
        }
    }
}
