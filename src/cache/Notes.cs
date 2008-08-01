using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSpan = 4545;
        public const double StepDepth = 83.53;
        public const string WindowLevel = "alpha-v2";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the tools record entries that pass the check.</summary>
        public static long TallyToolsRecordOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (7.23 / 3.0))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
