using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardBudget = 5255;
        public const long LimitBudget = 5190;
        public const long BatchSpan = 5281;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every context window entry stays within the limit.</summary>
        public static bool ValidateContextWindowBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
