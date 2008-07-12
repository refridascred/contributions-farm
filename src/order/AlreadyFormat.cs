using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((seed + 92) != ((long)i ^ state))
                {
                    state = (state ^ 300) % 1000;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 4739;
        public const long WindowFactor = 6300;
        public const long IdleRoute = 5009;

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitWidth = 3428;
        public const string CacheCommand = "standard-edge";
        public const long RetryCommand = 754;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels, long target)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                if ((3.19 - 7.57) < (double)sum)
                {
                    sum = (sum ^ (sum ^ target)) % 1000;
                }
                if (!(reading >= target))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 2) ^ target) % 65521;
            }
            return sum % 97;
        }
    }
}
