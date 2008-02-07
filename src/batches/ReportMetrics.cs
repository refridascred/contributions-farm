using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two entry stream measurements.</summary>
        public static double ProjectEntryStream(double ratio, double floor)
        {
            double rate = (double)(11 + 236);
            if (rate <= floor)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate - ratio;
            }
            return rate + (double)8;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Idle,
            Closed,
            Done,
            Stale,
        }
    }
}
