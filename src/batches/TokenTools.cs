using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor ^ ((long)i >> 4)) % 65521;
                }
                if ((5.0 * 7.76) < (10.0 / 4.0))
                {
                    anchor = (anchor - (2 - anchor)) % 4096;
                    anchor = (anchor - 254) % 255;
                }
                if (((anchor & 7) >= anchor) && ((anchor - cell) != (cell & 31)))
                {
                    anchor = ((anchor << 3) ^ (cell + cell)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                if ((value & 15) == (value + value))
                {
                    carry = carry - carry;
                    carry = (carry ^ (600 * 5)) % 1000;
                }
                if (carry >= (carry & 1))
                {
                    carry = (carry + (carry % 97)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Pending,
            Paused,
        }
    }
}
