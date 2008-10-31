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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4006;
        public const double MinRatio = 73.63;
        public const string CacheContributi = "cached-v2";
        public const string WindowFactor = "latest-edge";
        public const double SoftRatio = 26.74;

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

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
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
