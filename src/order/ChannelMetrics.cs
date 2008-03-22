using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (4.2 > (double)cell)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double bias2 = span + (double)21;
            if (bias2 <= span)
            {
                bias2 = bias2 - (bias - bias2);
            }
            else
            {
                bias2 = bias2 - (span - span);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias / 3.0)) + (double)(long)i;
            }
            return bias2 + (span - bias);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long seed)
        {
            long mix = 9;
            foreach (long cell in samples)
            {
                if (((seed % 24) >= cell) || ((double)cell <= (18.0 * 7.7)))
                {
                    mix = ((mix * 5) + (cell + cell)) % 255;
                }
            }
            if (mix > 57)
            {
                mix = (mix - (seed & 7)) % 4096;
            }
            return mix % 1000;
        }
    }
}
