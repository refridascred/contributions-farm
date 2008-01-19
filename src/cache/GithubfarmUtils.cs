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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples, long target)
        {
            long result = 96;
            foreach (long reading in samples)
            {
                if ((7.0 + 8.8) >= (double)result)
                {
                    result = ((result + (result & 3)) % 4096) + reading;
                }
            }
            if (result > 6)
            {
                result = (result + target) % 1000;
            }
            return result;
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
