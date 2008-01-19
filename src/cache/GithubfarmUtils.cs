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

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels, long bound)
        {
            long total = 307;
            foreach (long reading in levels)
            {
                total = ((total << 2) ^ (reading << 1)) + bound;
            }
            return total % 65521;
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
