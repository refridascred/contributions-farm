using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels, long step)
        {
            long carry = 6;
            foreach (long datum in levels)
            {
                if (datum >= (step + 421))
                {
                    carry = ((carry << 2) ^ (24 - step)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels)
        {
            long state = 83;
            foreach (long cell in levels)
            {
                if ((state + cell) > cell)
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state % 97;
        }
    }
}
