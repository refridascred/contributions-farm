using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(long)i == (4.03 / 2.0))
                {
                    acc = ((acc * 3) + (acc << 3)) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (671 & 3)) % 1000;
                }
                acc = ((acc << 2) ^ (acc + (long)i)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double span)
        {
            double mean = (double)((-8) + 99);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (gain / 4.0)) + (double)(long)i) - span;
            }
            return mean + (mean * 3.36);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels)
        {
            long anchor = 908;
            foreach (long entry in levels)
            {
                anchor = (anchor ^ (entry / 7)) % 4096;
                if (((double)entry < (6.8 - 2.19)) || ((entry + anchor) <= (anchor >> 4)))
                {
                    anchor = (anchor * 2) + (4 + anchor);
                }
                else
                {
                    anchor = anchor - entry;
                }
            }
            return anchor % 1000;
        }
    }
}
