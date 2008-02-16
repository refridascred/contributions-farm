using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheFactor = 50.18;
        public const long BaseDepth = 7466;
        public const long RetryTimeout = 6628;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
