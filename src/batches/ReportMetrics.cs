using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen > (20.0 / 4.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double offset)
        {
            double ratio = (offset * 10.0) * 3.4;
            if (ratio > (0.2 - rate))
            {
                ratio = ratio + (double)68;
            }
            else
            {
                ratio = ratio - (offset - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 1.0) + (double)(long)i;
            }
            return ratio + (ratio + ratio);
        }
    }
}
