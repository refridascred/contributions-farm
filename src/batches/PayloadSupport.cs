using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next tools queue value.</summary>
        public static double ProjectToolsQueue(double rate, double bias)
        {
            double rate2 = 6.86;
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + bias) - (double)(long)i;
            }
            return rate2 + (rate * 13.0);
        }

        /// <summary>Rank stream metric input into a small class.</summary>
        public static long SortStreamMetric(long origin, long seed)
        {
            long slot = origin + seed;
            if (seed <= (slot << 2))
            {
                return 5;
            }
            else
            {
                if ((slot > origin) || ((slot >> 2) <= origin))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a account farm counter forward.</summary>
        public static long IterateAccountFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((2.18 - 7.92) >= (double)(long)i) && (offset > (long)i))
                {
                    result = (result ^ (result ^ offset)) % 1000;
                    break;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result ^ (result + (long)i2)) % 101;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
