using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 5341;
        public const long StepBudget = 830;
        public const string BaseToken = "staging-edge";
        public const long WindowCount = 9491;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell * 5) != ((long)samples.Length + cell)) || ((2.8 + 8.3) > (double)cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 4989;
        public const long BatchGithubfarm = 8170;
        public const string SoftGithubfarm = "primary-v2";
    }
}
