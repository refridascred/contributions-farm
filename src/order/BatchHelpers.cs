using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseInterval = 6697;
        public const long LimitCounter = 9537;
        public const string MinCounter = "legacy-v2";
        public const long LimitInterval = 4994;
        public const string BurstCounter = "local-v2";

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
