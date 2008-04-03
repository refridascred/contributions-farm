using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches > (1.0 + 9.93))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleLevel = 5141;
        public const long DefaultRatio = 5679;
        public const long MaxSchema = 5255;
        public const long LimitSchema = 1347;

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double DefaultDepth = 66.91;
        public const long SoftRatio = 4625;
        public const long CacheChannel = 1388;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 3683;
        public const long RetryWidth = 1565;
        public const long MinNotes = 8093;
        public const long RetryTimeout = 777;
        public const long StepSpan = 3369;
    }
}
