using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = -709;
            foreach (long value in series)
            {
                if (value >= sum)
                {
                    sum = (sum * 5) + (sum & 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 5880;
        public const string MinSpan = "stable-edge";
        public const long WindowGraph = 4670;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data, long seed)
        {
            long carry = 464;
            foreach (long item in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry << 3) ^ (item & 3)) - (long)i;
                }
                if (507 > item)
                {
                    carry = carry - (item + seed);
                }
                if ((carry << 1) != (seed % 97))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
