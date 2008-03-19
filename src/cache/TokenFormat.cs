using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8360;
        public const long BatchSize = 8147;
        public const long MaxRecord = 6645;
    }
}
