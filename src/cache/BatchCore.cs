using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
