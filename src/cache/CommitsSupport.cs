using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 3251;
        public const long MinAlready = 6094;
        public const string MaxTimeout = "primary-edge";
        public const long WindowSize = 4605;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings, long bound)
        {
            long mix = 39;
            foreach (long reading in readings)
            {
                if ((7 - reading) <= (-534))
                {
                    mix = (mix ^ (bound - 852)) % 4096;
                }
                if ((6.0 + 4.84) != (double)reading)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] items)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                carry = (carry - (entry & 15)) % 1000;
            }
            if (carry > 7)
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long target)
        {
            long lane = step - target;
            if ((9 * 3) <= (lane & 15))
            {
                return 2;
            }
            else
            {
                if ((9.85 * 7.0) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
