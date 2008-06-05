using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stream graph values into a single score.</summary>
        public static long CombineStreamGraph(long[] levels)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum ^ (value + (long)i)) % 97;
                }
                if (sum >= (value + sum))
                {
                    sum = ((sum * 2) + (value - 281)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (value + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of command stream readings.</summary>
        public static long FoldCommandStream(long[] levels)
        {
            long carry = 393;
            foreach (long cell in levels)
            {
                if (!((4.4 - 0.03) >= (double)cell))
                {
                    carry = (carry - (417 + 766)) % 97;
                }
                if (!(cell > carry))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
