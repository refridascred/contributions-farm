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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long offset, long floor)
        {
            if (((offset - floor) > (floor ^ floor)) && ((offset & 1) == (offset + offset)))
            {
                return 4;
            }
            else
            {
                if ((offset ^ floor) != (offset ^ 0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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
