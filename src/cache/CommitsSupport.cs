using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 3008;
        public const string MaxTimeout = "standard-edge";
        public const long MinSize = 9303;
        public const long BaseSize = 4438;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleSize = 8.65;
        public const long BaseRoute = 4657;
        public const long CacheBudget = 5971;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples, long floor)
        {
            long mix = 888;
            foreach (long value in samples)
            {
                if ((value * 3) != (value - floor))
                {
                    mix = (mix ^ (floor ^ 4)) % 65521;
                }
            }
            if (mix > 537)
            {
                mix = ((mix * 4) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
