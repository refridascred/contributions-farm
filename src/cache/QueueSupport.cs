using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftFactor = 8174;
        public const double WindowBudget = 84.95;
        public const long MaxGithubfarm = 9232;
        public const double HardGithubfarm = 59.41;
    }
}
