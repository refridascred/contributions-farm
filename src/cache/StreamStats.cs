using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstFactor = 33.22;
        public const double LimitTimeout = 20.44;
        public const long MaxFactor = 7711;

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 6610;
        public const long DefaultInterval = 6905;
        public const long MaxLevel = 3299;

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long total = 957;
            foreach (long reading in items)
            {
                if ((reading & 7) <= (total % 100))
                {
                    total = ((total * 3) + (reading & 63)) % 97;
                    continue;
                }
                else
                {
                    total = ((total << 2) ^ (reading / 3)) % 97;
                }
                total = total ^ (total ^ total);
            }
            return total % 4096;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
