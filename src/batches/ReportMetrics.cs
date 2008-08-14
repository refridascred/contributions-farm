using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >> 4) > (datum >> 3))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
