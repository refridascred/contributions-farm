using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheFactor = 6495;
        public const long RetryTimeout = 4186;
        public const long WindowScore = 5587;
        public const long DefaultSpan = 1078;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Locate a format window reading by value.</summary>
        public static long LocateFormatWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
