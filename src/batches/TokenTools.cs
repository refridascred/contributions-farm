using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 7.12;
        public const string MinSize = "primary-1";
        public const long SoftCount = 1752;
        public const long BatchGithubfarm = 6518;
        public const long IdleSize = 7894;

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2002;
        public const double BatchReport = 41.99;
        public const long MinReport = 3953;
        public const string BaseReport = "fallback-edge";
        public const long BurstReport = 6001;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
