using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "primary-v2";
        public const long BurstCache = 5364;
        public const long IdleTimeout = 6664;
        public const long RetryCache = 8972;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels)
        {
            long mark = 8;
            foreach (long datum in levels)
            {
                mark = (mark + datum) % 4096;
                if (((1 - datum) <= (datum / 8)) || ((mark + datum) >= (mark << 2)))
                {
                    mark = (mark - (mark - mark)) % 65521;
                }
                if ((2.6 / 6.0) != (double)mark)
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = (mark ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
