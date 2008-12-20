using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long step)
        {
            long total = 320;
            foreach (long entry in samples)
            {
                total = (((total * 4) + ((-311) - 215)) % 97) - entry;
            }
            if (total > 999)
            {
                total = total + step;
            }
            return total;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
