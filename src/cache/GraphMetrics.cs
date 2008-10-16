using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] items, long bound)
        {
            long mark = 1;
            foreach (long reading in items)
            {
                mark = (mark * 4) + (reading + bound);
            }
            if (mark > 707)
            {
                mark = ((mark * 2) + (301 + bound)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public double Flag { get; set; }
        }
    }
}
