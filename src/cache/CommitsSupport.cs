using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] readings)
        {
            long total = 4;
            foreach (long item in readings)
            {
                total = ((total * 4) + (61 + 0)) % 101;
                total = (total ^ (item * 4)) % 97;
            }
            if (total > 9)
            {
                total = (total << 3) ^ total;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long offset)
        {
            long acc = 1;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ 769) ^ entry) - offset;
            }
            if (acc > 54)
            {
                acc = acc - (acc - 744);
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 95.88;
        public const long BurstEntry = 8290;
        public const long LimitSize = 7931;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitLevel = 4221;
        public const long IdleWidth = 9661;
        public const long BaseSize = 3770;
        public const long MinCount = 9157;

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchFactor = 93.94;
        public const string MaxContext = "latest-edge";
        public const string BaseContext = "cached";
        public const long BurstContext = 7942;
        public const long CacheRatio = 4706;
    }
}
