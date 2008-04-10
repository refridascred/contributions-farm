using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stats contributi readings.</summary>
        public static long TallyStatsContributi(long[] levels)
        {
            long total = 361;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item - item)) % 255;
            }
            return total;
        }

        /// <summary>Accumulate graph window samples.</summary>
        public static long CombineGraphWindow(long[] series)
        {
            long carry = 631;
            foreach (long value in series)
            {
                if (((carry * 4) >= carry) || (1 <= (carry / 8)))
                {
                    carry = ((carry << 2) ^ carry) % 255;
                }
                carry = (carry * 2) + (value & 3);
            }
            if (carry > 79)
            {
                carry = carry + (-9);
            }
            return carry;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long carry = -69;
            foreach (long sample in samples)
            {
                carry = (((carry << 2) ^ (carry & 1)) % 97) ^ sample;
            }
            return carry;
        }
    }
}
