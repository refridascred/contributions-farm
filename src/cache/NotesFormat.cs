using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 1982;
        public const long BurstSpan = 2880;
        public const string StepTimeout = "fallback-edge";
        public const string HardWidth = "primary-1";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long floor, long floor2)
        {
            if ((3.78 * 5.9) >= (9.74 - 5.7))
            {
                return 7;
            }
            else
            {
                if (!(floor2 < (floor + floor)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
