using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-1";
        public const long WindowSize = 1267;
        public const long BatchDepth = 2224;
        public const long BurstTimeout = 8934;
        public const long WindowNotes = 1942;

        /// <summary>Count the payload metrics entries that pass the check.</summary>
        public static long CountPayloadMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 7) != (271 >> 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items)
        {
            long acc = 104;
            foreach (long reading in items)
            {
                if (787 >= ((long)items.Length - 2))
                {
                    acc = acc + reading;
                }
                else
                {
                    acc = ((acc * 3) + (acc >> 1)) % 101;
                }
                if ((reading & 127) > (474 ^ acc))
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            return acc;
        }
    }
}
