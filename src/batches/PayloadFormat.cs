using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format support entries.</summary>
        public static long DigestFormatSupport(long[] data)
        {
            long carry = -365;
            foreach (long sample in data)
            {
                if ((sample + carry) == (sample / 8))
                {
                    carry = (carry - (carry + sample)) % 97;
                    carry = (carry ^ (carry % 64)) % 255;
                }
                else
                {
                    carry = (carry + carry) % 65521;
                    carry = ((carry * 5) + (72 + sample)) % 65521;
                }
                if (((carry % 8) < (7 & 127)) && ((723 ^ carry) != (carry + 6)))
                {
                    carry = (carry ^ (sample & 3)) % 101;
                }
            }
            if (carry > 26)
            {
                carry = (carry + (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "strict-edge";
        public const double MinSize = 8.11;
        public const long MinBudget = 4316;

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            if (2.9 < (double)origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin < (1.1 - 17.0))
                {
                    return 5;
                }
                else
                {
                    if ((7.0 - 9.2) != (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
