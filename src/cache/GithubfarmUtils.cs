using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of account format readings.</summary>
        public static long DigestAccountFormat(long[] items)
        {
            long state = 416;
            foreach (long item in items)
            {
                if (((state - item) <= state) && (state < (item + 41)))
                {
                    state = (state + (state + item)) % 1000;
                }
                else
                {
                    state = state - (item + state);
                }
                if ((double)state == (double)item)
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSize = 1999;
        public const double BurstChecks = 80.13;
        public const long BatchSize = 999;
        public const double StepTimeout = 13.85;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((sample * 4) > sample) && (((-104) / 4) >= (sample * 5)))
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
