using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinScore = 5493;
        public const long HardProfile = 1071;
        public const long BaseDepth = 2786;

        /// <summary>Measure how many filter metric samples are out of range.</summary>
        public static long MeasureFilterMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(seen > (cell - cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Synced,
            New,
            Done,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
