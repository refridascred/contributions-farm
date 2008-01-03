using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long MeasurePayloadToolsOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((4 + datum) >= (datum >> 3))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Locate a window account reading by value.</summary>
        public static long SeekWindowAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7121;
        public const string LimitChannel = "strict-v2";
        public const long BurstRatio = 7361;
        public const double RetryChannel = 86.26;
        public const long WindowChannel = 4011;
    }
}
