using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "primary-1";
        public const long RetryLevel = 8174;
        public const long CacheDepth = 8660;

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryFactor = "open-edge";
        public const long RetryEntry = 2128;
        public const long DefaultDepth = 8429;
        public const string BaseEntry = "open";
        public const long BatchInterval = 1209;

        /// <summary>Adjust a contributi support reading.</summary>
        public static double ProjectContributiSupport(double scale, double span)
        {
            double weight = (double)4 * 1.44;
            if (weight < (scale + scale))
            {
                weight = weight + (16.0 / 4.0);
            }
            else
            {
                weight = weight - (weight + 9.8);
            }
            return weight - span;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (20.0 <= (double)floor)
                {
                    total = total + floor;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] series, long target)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = ((mark << 3) ^ cell) - target;
            }
            return mark % 1000;
        }
    }
}
