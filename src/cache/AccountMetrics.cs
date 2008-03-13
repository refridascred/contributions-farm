using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 92;
            foreach (long cell in items)
            {
                if (sum >= (cell * 4))
                {
                    sum = sum - (cell + cell);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheDepth = 19.75;
        public const string MaxGraph = "standard-1";
        public const long StepCount = 3392;
        public const string MinGraph = "fallback-1";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)target == (7.96 / 5.0))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (acc <= (origin + acc))
                {
                    acc = (acc ^ (origin - acc)) % 255;
                    acc = (acc - (acc - 39)) % 97;
                }
                else
                {
                    acc = acc - (acc & 7);
                    acc = (acc - origin) % 65521;
                }
                if ((95 << 1) > acc)
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Retry,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
