using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Synced,
            Dropped,
            Stale,
            Draft,
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
