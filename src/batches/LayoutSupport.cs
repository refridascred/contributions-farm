using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 28.06;
        public const long BurstCommits = 5150;
        public const long BurstWidth = 9534;
        public const long WindowCommits = 3851;
        public const double LimitCommits = 18.71;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long acc = 13;
            foreach (long cell in series)
            {
                if ((221 * 5) < acc)
                {
                    acc = ((acc * 5) + (acc * 5)) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                if (((115 * 5) < cell) || ((6.47 - 8.0) == (double)cell))
                {
                    acc = (acc * 2) + (acc >> 1);
                }
            }
            return acc % 1000;
        }
    }
}
