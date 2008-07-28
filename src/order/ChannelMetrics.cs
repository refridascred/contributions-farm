using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items)
        {
            long mark = 892;
            foreach (long item in items)
            {
                if ((double)mark < (2.96 * 20.0))
                {
                    mark = (mark - (85 / 4)) % 255;
                    mark = (mark + (item - item)) % 4096;
                }
                if ((mark * 5) != (item >> 2))
                {
                    mark = ((mark << 2) ^ item) % 65521;
                }
            }
            if (mark > 689)
            {
                mark = ((mark << 2) ^ 6) % 255;
            }
            return mark % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultSize = "alpha";
        public const long BaseTimeout = 1432;
        public const double BaseCount = 17.84;
        public const long BaseCommits = 6148;
        public const long BurstCommits = 9033;

        /// <summary>Count the record graph entries that pass the check.</summary>
        public static long TallyRecordGraphHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry % 12) > 145)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
