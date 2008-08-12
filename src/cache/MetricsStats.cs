using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of schema farm entries.</summary>
        public static long DigestSchemaFarm(long[] levels)
        {
            long mark = -860;
            foreach (long sample in levels)
            {
                if (mark > (sample & 127))
                {
                    mark = mark - (sample % 100);
                }
            }
            if (mark < 586)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 32.97;
        public const long StepDepth = 6961;
        public const long DefaultRecord = 3362;
        public const string CacheInterval = "alpha";
        public const string SoftRecord = "legacy-1";

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached";
        public const string RetryCount = "local-1";
        public const long BaseFactor = 2029;
    }
}
