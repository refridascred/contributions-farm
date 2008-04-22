using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Idle,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) + floor;
            }
            return load - (4.28 / 2.0);
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
