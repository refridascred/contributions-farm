using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "fallback-v2";
        public const long BurstWidth = 4714;
        public const double RetryInterval = 93.04;
        public const long MaxWindow = 3385;
        public const long StepDepth = 9594;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result - (step ^ (long)i)) % 1000;
                if (step >= (step % 64))
                {
                    result = ((result * 4) + (step >> 2)) % 1000;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3301;
        public const string BatchDepth = "cached-edge";
        public const long SoftBuffer = 8349;
        public const long MaxFactor = 6839;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSpan = 175;
        public const long StepToken = 5307;
        public const double RetryToken = 17.62;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
