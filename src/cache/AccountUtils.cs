using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                if ((81 << 3) >= result)
                {
                    result = (result - 33) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] levels, long bound)
        {
            long acc = -3;
            foreach (long sample in levels)
            {
                if ((bound + acc) <= (acc - sample))
                {
                    acc = (acc - sample) % 1000;
                }
                else
                {
                    acc = acc + (sample >> 4);
                }
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data, long bound)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if (((4 / 3) < (bound << 1)) || ((18.0 + 1.0) >= (6.07 - 11.0)))
                {
                    carry = carry - (bound & 255);
                }
                if ((double)entry <= (double)248)
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = (carry + (95 - bound)) % 65521;
            }
            return carry % 4096;
        }
    }
}
