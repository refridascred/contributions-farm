using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxFactor = 18.61;
        public const string StepContributi = "alpha-edge";
        public const long BaseContributi = 178;
        public const long HardContributi = 5608;
        public const string IdleBudget = "strict-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultTimeout = 64.1;
        public const string IdleGithubfarm = "primary";
        public const double StepRatio = 8.65;

        /// <summary>Look up the position of a batch cluster sample.</summary>
        public static long LocateBatchClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
