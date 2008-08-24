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

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double scale2 = 7.51 / 6.0;
            if (scale2 < (6.02 * 1.48))
            {
                scale2 = (scale2 - (offset + 0.9)) - scale;
            }
            else
            {
                scale2 = scale2 + scale2;
            }
            return scale2 + 6.25;
        }
    }
}
