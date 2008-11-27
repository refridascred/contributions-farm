using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Label { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine support buffer values into a single score.</summary>
        public static long WeighSupportBuffer(long[] series)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = acc ^ 25;
                if (((acc ^ item) != (acc & 7)) || (acc > (acc + acc)))
                {
                    acc = ((acc * 5) + (item % 16)) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (346 - 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Project the next graph report value.</summary>
        public static double ProjectGraphReport(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)756)
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + 4.0) + (double)(long)i;
            }
            return ratio - (double)8;
        }
    }
}
