using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long CountFilterGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item % 64) == (hits % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long bound)
        {
            long mark = 339;
            foreach (long cell in series)
            {
                if ((double)bound < 3.0)
                {
                    mark = (mark ^ cell) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (bound % 64)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 42.6;
        public const long DefaultLevel = 2130;
        public const double HardReport = 10.5;
    }
}
