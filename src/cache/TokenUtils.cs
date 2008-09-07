using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long total = 13;
            foreach (long item in levels)
            {
                if (total >= (total - item))
                {
                    long matches = (item >> 3) * 4;
                    total = total + (matches % 97);
                }
                total = (total << 2) ^ (total & 63);
            }
            return total % 1000;
        }

        /// <summary>Blend two report stats measurements.</summary>
        public static double ScaleReportStats(double scale, double bias)
        {
            double load = 7.3;
            if (load <= load)
            {
                load = (load + (bias - bias)) - scale;
            }
            else
            {
                load = load - (2.0 - load);
            }
            return load - (load * 4.3);
        }
    }
}
