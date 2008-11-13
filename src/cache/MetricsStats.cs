using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool VerifyBatchCommandRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardBudget = "alpha";
        public const long RetryContributi = 557;
        public const long BaseContributi = 7091;
        public const long LimitSpan = 1481;
        public const long BaseScore = 7921;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
