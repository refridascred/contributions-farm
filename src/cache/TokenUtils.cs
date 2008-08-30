using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 4451;
        public const long IdleSpan = 1374;
        public const double HardContributi = 91.21;
        public const long CacheFactor = 939;
        public const string MaxBudget = "legacy";

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long CombineStreamBatch(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if (((double)state < (double)datum) && ((datum & 7) <= state))
                {
                    state = ((state * 4) + state) % 65521;
                }
                else
                {
                    state = (state + (state ^ datum)) % 255;
                }
            }
            if (state > 6)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state;
        }
    }
}
