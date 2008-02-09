using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 792;
        public const string HardCommits = "stable-edge";
        public const long CacheSpan = 4300;
        public const long HardInterval = 3644;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Idle,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] samples)
        {
            long acc = 33;
            foreach (long cell in samples)
            {
                acc = (acc ^ (cell + acc)) % 101;
            }
            if (acc < 62)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2008;
        public const double IdleWidth = 63.25;
        public const long SoftSpan = 5954;
        public const double BurstRatio = 67.66;
        public const long BatchDepth = 2487;
    }
}
