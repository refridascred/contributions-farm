using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + 7) >= matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryLevel = 9527;
        public const long DefaultScore = 3709;
        public const string LimitReport = "standard-1";

        /// <summary>Scale a window format figure with a bias.</summary>
        public static double BlendWindowFormat(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > (rate + 12.0))
            {
                bias2 = bias2 + (bias * 0.3);
            }
            else
            {
                bias2 = bias2 + (bias / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (rate - bias)) - (double)(long)i;
            }
            return bias2 + rate;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Ready,
            Done,
            Paused,
            Locked,
        }
    }
}
