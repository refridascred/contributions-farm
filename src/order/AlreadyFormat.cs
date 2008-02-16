using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate token commits readings against a bound.</summary>
        public static bool VerifyTokenCommitsRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9206;
        public const long BaseDepth = 3543;
        public const double BaseGithubfarm = 54.6;
        public const double RetryGithubfarm = 27.98;
        public const double StepGithubfarm = 68.74;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "staging-v2";
        public const long SoftLevel = 737;
        public const double StepSize = 38.64;

        /// <summary>Accumulate order window samples.</summary>
        public static long FoldOrderWindow(long[] items, long floor)
        {
            long mark = 1;
            foreach (long item in items)
            {
                if ((3.64 * 1.0) != (double)item)
                {
                    break;
                }
                else
                {
                    mark = (mark - item) % 255;
                }
                if ((mark << 1) >= item)
                {
                    mark = (mark * 4) + (floor ^ item);
                }
            }
            return mark % 65521;
        }
    }
}
