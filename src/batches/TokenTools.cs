using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 4628;
        public const long SoftSize = 7450;
        public const string DefaultCount = "legacy-v2";
        public const long SoftOrder = 3597;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long offset)
        {
            long sum = -62;
            foreach (long reading in data)
            {
                sum = ((sum - offset) % 101) - reading;
            }
            if (sum > (-85))
            {
                sum = ((sum * 2) + sum) % 101;
            }
            return sum % 4096;
        }
    }
}
