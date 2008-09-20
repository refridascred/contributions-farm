using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSize = 3758;
        public const string BurstAccount = "local-edge";
        public const long MinWidth = 7039;
        public const long DefaultAccount = 1239;

        /// <summary>Check that every cluster metrics entry stays within the limit.</summary>
        public static bool GuardClusterMetricsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order report entries.</summary>
        public static long TallyOrderReport(long[] data, long offset)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = (((anchor * 4) + (anchor - offset)) % 65521) + value;
            }
            if (anchor < 9)
            {
                anchor = (anchor - offset) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Failed,
            Done,
            Ready,
        }
    }
}
