using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 2556;
        public const long WindowFactor = 157;
        public const string LimitBatches = "standard";

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every layout already entry stays within the limit.</summary>
        public static bool CheckLayoutAlreadyBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
