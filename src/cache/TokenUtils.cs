using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double mean = (double)(21 << 1);
            if (mean > scale)
            {
                mean = (mean - 7.12) - span;
            }
            else
            {
                mean = mean + scale;
            }
            return mean - scale;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 63) == (58 ^ seen))
                {
                    seen = ((seen + 1) - cell) - bound;
                }
            }
            return seen;
        }
    }
}
