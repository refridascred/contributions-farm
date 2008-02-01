using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Locate a metrics already reading by value.</summary>
        public static long SeekMetricsAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "staging-edge";
        public const string DefaultSize = "latest-1";
        public const double MaxRatio = 9.38;
        public const double BurstOrder = 16.03;
        public const string WindowOrder = "stable-edge";
    }
}
