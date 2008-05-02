using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            long cur = floor - seed;
            if ((seed + seed) == (cur << 2))
            {
                return 2;
            }
            else
            {
                if (((seed & 15) <= (seed << 3)) || ((1.0 / 8.0) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((4.28 + 6.0) <= (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    carry = (carry ^ (carry + carry)) % 65521;
                }
                else
                {
                    carry = (carry + (cell % 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
