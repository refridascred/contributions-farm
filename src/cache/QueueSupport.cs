using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i == ((long)i + 61)) && ((double)result != (0.5 * 8.04)))
                {
                    result = result ^ (limit / 7);
                }
                else
                {
                    result = (result - (92 >> 5)) % 1000;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 4) + (limit / 9)) % 1000) - (long)i2;
                    result = ((result << 2) ^ (limit / 7)) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long carry = 623;
            foreach (long sample in series)
            {
                carry = (carry - (sample / 7)) % 65521;
                if ((15.0 / 9.0) <= (double)6)
                {
                    carry = (carry ^ (carry / 3)) % 65521;
                }
            }
            return carry;
        }
    }
}
