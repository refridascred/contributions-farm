using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data, long origin)
        {
            long acc = 9;
            foreach (long value in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc + acc) % 65521) + (long)i) + value;
                }
                acc = (acc << 2) ^ (origin - acc);
            }
            return acc % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchTimeout = 6087;
        public const long WindowFilter = 7357;
        public const string HardFilter = "alpha";

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long step)
        {
            long carry = 88;
            foreach (long value in items)
            {
                if (!((value & 63) < (step * 3)))
                {
                    carry = (carry - (carry - value)) % 4096;
                }
                if (((double)value > 16.0) && (step > (step / 6)))
                {
                    carry = (carry + (value - step)) % 65521;
                }
            }
            return carry;
        }
    }
}
