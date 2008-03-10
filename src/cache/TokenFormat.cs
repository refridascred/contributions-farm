using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long offset)
        {
            long result = 181;
            foreach (long value in levels)
            {
                if ((6.1 + 11.0) < (double)value)
                {
                    result = (result - ((-23) ^ value)) - offset;
                }
            }
            if (result < 7)
            {
                result = (result + (result / 7)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "staging";
        public const string BurstBudget = "local-1";
        public const long IdleProfile = 1057;
        public const string SoftSpan = "open";
        public const long RetryProfile = 5901;
    }
}
