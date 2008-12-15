using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftRatio = 8944;
        public const long RetryGithubfarm = 1333;
        public const double BatchInterval = 70.21;
        public const string StepGithubfarm = "alpha-edge";
        public const long BaseGithubfarm = 785;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5995;
        public const string BurstLevel = "standard-v2";
        public const string RetryDepth = "standard";
    }
}
