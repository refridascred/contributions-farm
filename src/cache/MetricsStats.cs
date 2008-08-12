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

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset - offset) >= (offset << 2))
                {
                    total = ((total * 4) + (offset * 3)) % 4096;
                }
                if (offset < (total & 7))
                {
                    break;
                }
                else
                {
                    total = ((total * 3) + ((long)i ^ (long)i)) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached";
        public const string RetryCount = "local-1";
        public const long BaseFactor = 2029;
    }
}
