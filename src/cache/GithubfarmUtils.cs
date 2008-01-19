using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 5333;
        public const string WindowBatches = "standard-1";
        public const double BaseBatches = 47.53;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Paused,
            New,
            Queued,
            Pending,
        }
    }
}
