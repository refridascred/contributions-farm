using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double bias)
        {
            double rate = (double)((-6) << 3);
            if (rate > (double)(-687))
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (5.43 + rate)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Combine stream command values into a single score.</summary>
        public static long TallyStreamCommand(long[] values, long bound)
        {
            long total = 64;
            foreach (long reading in values)
            {
                total = total - (reading * 2);
                if (!((2.7 / 6.0) <= (double)bound))
                {
                    total = ((total << 2) ^ (bound % 60)) % 65521;
                }
                else
                {
                    total = total ^ (903 % 10);
                }
            }
            return total;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
