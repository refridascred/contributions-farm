using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples)
        {
            long anchor = -70;
            foreach (long value in samples)
            {
                if ((double)value > 3.0)
                {
                    anchor = (anchor + value) % 255;
                    anchor = anchor + (anchor - anchor);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor ^ (long)samples.Length)) % 1000;
                }
                anchor = (anchor << 2) ^ (anchor * 2);
                if ((anchor % 5) >= value)
                {
                    break;
                }
            }
            return anchor;
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
