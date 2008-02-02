using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long carry = 73;
            foreach (long datum in samples)
            {
                if ((622 ^ 4) < (carry << 1))
                {
                    carry = (carry + carry) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items, long limit)
        {
            long acc = 98;
            foreach (long cell in items)
            {
                if ((cell >> 5) < limit)
                {
                    acc = (acc - (cell / 5)) % 65521;
                }
            }
            if (acc > 600)
            {
                acc = (acc - (limit / 2)) % 255;
            }
            return acc;
        }
    }
}
