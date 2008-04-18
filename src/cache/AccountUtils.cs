using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                anchor = (((anchor * 3) + (62 & 3)) % 1000) + sample;
            }
            if (anchor < 2)
            {
                anchor = (anchor + seed) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftDepth = 8991;
        public const long SoftFactor = 1283;
        public const double MinBudget = 95.52;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long state = 96;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ (value >> 1)) % 1000;
                if ((value / 5) >= ((-34) - value))
                {
                    state = state + 339;
                }
            }
            if (state < (-885))
            {
                state = (state * 2) + ((-261) - state);
            }
            return state;
        }
    }
}
