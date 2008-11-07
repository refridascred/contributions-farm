using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data, long offset)
        {
            long mix = 862;
            foreach (long cell in data)
            {
                mix = ((mix + (offset + 143)) % 65521) + cell;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 4804;
        public const string MaxGithubfarm = "primary-1";
        public const long StepGithubfarm = 5472;
        public const long RetryGithubfarm = 8779;

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
