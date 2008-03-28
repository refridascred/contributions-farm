using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            long diff = origin ^ offset;
            if ((origin & 15) < (9 & 3))
            {
                return 3;
            }
            else
            {
                if ((3.0 - 11.0) >= (double)diff)
                {
                    return 0;
                }
                else
                {
                    if ((7.09 - 3.09) <= (double)diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ offset) <= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry - (carry % 60)) ^ (long)i2;
                }
                if ((long)i >= offset)
                {
                    carry = (carry - ((long)i + carry)) % 97;
                    carry = (carry - carry) % 4096;
                    break;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
