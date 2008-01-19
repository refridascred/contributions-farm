using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MinCount = 69.38;
        public const long StepSchema = 6889;
        public const long LimitSchema = 6625;

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 6817;
        public const double WindowDepth = 51.99;
        public const long MinSize = 853;
        public const long MinTimeout = 7262;
        public const long MinCache = 5282;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
