using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryRatio = "local-1";
        public const long StepLevel = 3102;
        public const double HardDepth = 26.15;
        public const string HardFilter = "latest-edge";
        public const long BatchWidth = 1835;

        /// <summary>Audit account cluster readings against a rule.</summary>
        public static long CountAccountClusterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((matches <= (matches ^ step)) || ((double)step >= (6.1 - 5.33))))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double floor)
        {
            double weight = ratio;
            if (weight < (double)79)
            {
                weight = (weight - ratio) - floor;
            }
            return weight + ratio;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryTimeout = "open-edge";
        public const double CacheStats = 22.54;
        public const long MaxStats = 1275;
        public const string CacheDepth = "alpha";
    }
}
