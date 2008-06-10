using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            long prev = bound + origin;
            if ((double)origin <= (2.0 - 9.74))
            {
                return 4;
            }
            else
            {
                if ((7.5 * 5.14) > (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "primary";
        public const string BatchWindow = "local-1";
        public const long SoftWindow = 8284;
        public const long MaxWindow = 2687;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7099;
        public const long BaseRoute = 5780;
        public const double WindowRoute = 67.36;
        public const long SoftBudget = 2619;
        public const double BurstTimeout = 32.24;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3180;
        public const long BatchReport = 2902;
        public const string HardReport = "staging-1";
        public const double RetrySize = 79.33;
        public const double StepReport = 33.22;
    }
}
