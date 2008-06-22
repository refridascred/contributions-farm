using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long total = 119;
            foreach (long sample in levels)
            {
                total = (((total ^ (74 << 2)) % 101) - sample) - seed;
            }
            return total % 4096;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (116 < entry)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor report measurements.</summary>
        public static double SmoothEditorReport(double rate, double bias)
        {
            double ratio = rate + bias;
            if (ratio > 1.4)
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (bias / 6.0)) - (double)(long)i;
            }
            return ratio - (5.0 - bias);
        }
    }
}
