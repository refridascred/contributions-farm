using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 6206;
        public const long StepSpan = 3259;
        public const long IdleBudget = 6997;
        public const string RetryChecks = "legacy-v2";
        public const long BurstRatio = 9463;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches / 6) >= (entry ^ (long)items.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
