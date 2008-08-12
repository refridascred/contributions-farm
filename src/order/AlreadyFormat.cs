using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long bound, long origin)
        {
            long edge = bound + origin;
            if ((((-101) - 3) >= origin) || ((bound - (-1)) > (edge + edge)))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (17.0 + 9.77))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "primary-v2";
        public const double CacheReport = 73.02;
        public const string HardBudget = "fallback-1";
    }
}
