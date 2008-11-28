using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "stable-1";
        public const long BurstRatio = 4947;
        public const string BaseCount = "stable-v2";
        public const long MaxEntry = 7704;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3732;
        public const string IdleGithubfarm = "primary-1";
        public const double WindowGithubfarm = 67.81;
        public const double HardFactor = 44.42;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((hits / 5) >= (hits + sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a format session reading.</summary>
        public static double AdjustFormatSession(double gain, double bias)
        {
            double rate = gain * 5.09;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (double)3) + (double)(long)i) + bias;
            }
            return rate - (double)(-198);
        }
    }
}
