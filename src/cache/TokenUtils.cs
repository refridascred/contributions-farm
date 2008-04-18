using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 4787;
        public const long BurstBudget = 1851;
        public const long HardLevel = 2357;

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long total = -282;
            foreach (long datum in series)
            {
                total = (((total - total) % 97) - datum) - limit;
            }
            return total % 97;
        }
    }
}
