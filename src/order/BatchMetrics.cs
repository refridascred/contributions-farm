using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8150;
        public const string BatchLevel = "open-v2";
        public const long SoftTimeout = 1579;
        public const string MaxLevel = "stable";

        /// <summary>Measure how many account route samples are out of range.</summary>
        public static long MeasureAccountRouteGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count > datum)
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Synced,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double offset)
        {
            double ratio2 = (ratio / 9.0) * 2.3;
            if (ratio2 >= (ratio2 + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 / 4.0)) + offset;
            }
            return ratio2 - (ratio * 5.4);
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((floor * 5) > (cell << 2)) && !((matches + 51) >= (matches + 71)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
