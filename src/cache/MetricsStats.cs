using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 229;
        public const long MaxStream = 8259;
        public const double StepFactor = 6.17;
        public const long RetryStream = 5945;
        public const string CacheFactor = "alpha";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Pending,
            Closed,
            Paused,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if ((offset2 >= (1 + offset2)) || ((8 << 3) == (offset + delta)))
            {
                return 0;
            }
            else
            {
                if ((double)delta == (double)8)
                {
                    return 3;
                }
                else
                {
                    if (488 < (offset ^ delta))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
