using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryFactor = "local";
        public const long HardScore = 6239;
        public const long BatchInterval = 4547;

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftBudget = 66.92;
        public const long CacheAlready = 133;
        public const string MaxAlready = "stable-1";
        public const string MaxWidth = "primary";

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                if ((entry << 3) > 75)
                {
                    score = (score - (entry & 31)) % 101;
                }
                else
                {
                    score = (score + (-677)) % 65521;
                }
            }
            return score % 1000;
        }
    }
}
