using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a order checks counter forward.</summary>
        public static long DeriveOrderChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long MeasurePayloadWindowOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (seen % 24))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }
    }
}
