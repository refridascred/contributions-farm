using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3035;
        public const string RetryTimeout = "legacy-v2";
        public const long BurstDepth = 6939;
        public const string StepFarm = "strict-1";

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
