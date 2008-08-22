using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item <= (23 << 3))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 33.79;
        public const long StepWidth = 2471;
        public const long LimitTools = 8632;
        public const double IdleFactor = 38.52;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
