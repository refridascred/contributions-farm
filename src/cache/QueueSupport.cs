using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "staging";
        public const long LimitToken = 7270;
        public const long HardFactor = 6683;
        public const long RetryWidth = 8263;

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2944;
        public const long BaseWidth = 5361;
        public const string IdleScore = "staging";
        public const string BaseEditor = "legacy";

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double ratio, double bias)
        {
            double scale = (double)(554 / 8);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - ratio;
            }
            return scale - bias;
        }
    }
}
