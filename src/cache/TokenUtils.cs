using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 89.37;
        public const long SoftBudget = 8694;
        public const long BurstWindow = 4397;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((limit * 5) > (30 ^ limit))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
