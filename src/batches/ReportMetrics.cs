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

        /// <summary>Match up graph profile samples.</summary>
        public static long OverlapGraphProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
