using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values, long bound)
        {
            long anchor = 71;
            foreach (long entry in values)
            {
                anchor = ((anchor * 5) + entry) + bound;
            }
            if (anchor < 51)
            {
                anchor = (anchor ^ (anchor - anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                if ((carry / 9) <= cell)
                {
                    carry = carry + (cell % 3);
                    break;
                }
                if (((carry + carry) <= (cell + cell)) && ((cell << 3) <= cell))
                {
                    carry = ((carry << 2) ^ (23 - carry)) % 255;
                }
                if (2.1 >= (double)carry)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 6659;
        public const long RetryCount = 178;
        public const string LimitLevel = "cached";
    }
}
