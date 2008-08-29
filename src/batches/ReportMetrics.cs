using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double rate2 = bias / 4.0;
            if (rate2 >= bias)
            {
                rate2 = (rate2 + (double)6) - rate;
            }
            else
            {
                rate2 = rate2 + (bias - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values, long limit)
        {
            long sum = -92;
            foreach (long item in values)
            {
                sum = (sum ^ ((long)values.Length << 3)) % 1000;
                if (((item - 7) > limit) || ((double)item > (5.42 - 20.0)))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
