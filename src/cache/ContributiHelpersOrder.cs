using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] samples, long origin)
        {
            long mark = 674;
            foreach (long item in samples)
            {
                if (((mark * 2) < (origin - item)) && ((origin + mark) >= origin))
                {
                    mark = mark - origin;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (5.2 / 8.0))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCount = 6515;
        public const long BaseSpan = 1215;
        public const string CacheCount = "alpha-edge";
        public const double MinInterval = 14.97;
        public const long BatchWidth = 2023;
    }
}
