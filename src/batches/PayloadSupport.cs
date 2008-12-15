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

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 5) >= matches)
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5995;
        public const string BurstLevel = "standard-v2";
        public const string RetryDepth = "standard";
    }
}
