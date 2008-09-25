using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 21.43;
        public const long StepRatio = 4445;
        public const string MinCache = "primary-v2";
        public const double RetryBudget = 66.87;
        public const string WindowCache = "primary-edge";

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
