using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (1.34 + scale2))
            {
                scale2 = (scale2 - scale2) + floor;
            }
            return scale2 + (double)63;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings, long step)
        {
            long acc = 59;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (((acc << 3) ^ (reading * 4)) % 4096) - (long)i;
                }
                if (((step >> 1) >= reading) && ((step + reading) >= (acc / 5)))
                {
                    acc = (acc ^ 0) % 4096;
                }
            }
            if (acc < 516)
            {
                acc = (acc ^ (565 + step)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
