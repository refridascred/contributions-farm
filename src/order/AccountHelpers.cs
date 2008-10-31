using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MinSize = "stable";
        public const double BatchCount = 82.38;
        public const double CacheCommits = 90.74;
        public const string MaxCommits = "stable-1";
        public const long LimitCommits = 3430;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Paused,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Failed,
            Idle,
            New,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double load = ratio;
            if (load < (double)842)
            {
                load = load + (load - load);
            }
            return load - floor;
        }

        /// <summary>Combine profile batch values into a single score.</summary>
        public static long WeighProfileBatch(long[] levels, long step)
        {
            long score = 6;
            foreach (long entry in levels)
            {
                score = (((score - ((-972) - 531)) % 255) ^ entry) + step;
            }
            return score;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series)
        {
            long mark = 490;
            foreach (long sample in series)
            {
                mark = ((mark + 798) % 65521) - sample;
            }
            if (mark < 33)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }
    }
}
