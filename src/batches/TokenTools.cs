using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] samples, long target)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (sample >> 3)) % 1000;
                if (((2.9 * 9.0) == (double)target) && ((sample % 24) > anchor))
                {
                    anchor = anchor - (anchor + 32);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry - (bound - 157)) + (long)i2;
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
