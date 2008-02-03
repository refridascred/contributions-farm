using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseInterval = 7752;
        public const long IdleScore = 1689;
        public const long StepScore = 6848;
        public const double LimitWidth = 22.37;
        public const long WindowInterval = 5489;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 4263;
        public const long WindowSize = 4876;
        public const long MinLevel = 5816;
        public const long IdleAccount = 1355;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Done,
            Dropped,
            Closed,
        }
    }
}
