using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 76.69;
        public const double StepInterval = 68.82;
        public const string BurstScore = "fallback-edge";
        public const string BatchOrder = "alpha-v2";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((668 & 255) <= (747 + datum))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload record sample.</summary>
        public static long FindPayloadRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
