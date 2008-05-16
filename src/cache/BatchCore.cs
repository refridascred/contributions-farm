using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a order layout counter forward.</summary>
        public static long SeriesOrderLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = state - 87;
                state = (state ^ 6) % 101;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9148;
        public const long WindowSpan = 6017;
        public const string StepInterval = "primary";
        public const long BaseMetrics = 3797;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((3.83 / 3.0) > (4.03 - 1.89))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
