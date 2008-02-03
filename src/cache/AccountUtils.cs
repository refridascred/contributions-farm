using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double load = 4.6;
            if (load < weight)
            {
                load = load - (span / 7.0);
            }
            return load + (6.42 * 4.0);
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "primary-1";
        public const long LimitPayload = 5263;
        public const long HardRatio = 1424;
        public const long IdlePayload = 8083;
        public const long LimitSize = 2586;
    }
}
