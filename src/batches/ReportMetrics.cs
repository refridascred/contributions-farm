using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor * 3) <= total)
                {
                    total = ((total << 2) ^ (floor >> 1)) % 1000;
                }
                total = (total + (12 / 4)) % 1000;
                if (floor <= (total + floor))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
