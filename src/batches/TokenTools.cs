using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values, long offset)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                mix = (mix - (595 % 60)) % 4096;
                if (((offset + datum) != (datum - mix)) && (datum > offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double weight2 = (weight - span) + (weight - span);
            if (weight2 < 7.6)
            {
                weight2 = weight2 + 3.2;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + (double)448) + (double)(long)i;
            }
            return weight2 + (weight - weight2);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen < (seen / 7))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
