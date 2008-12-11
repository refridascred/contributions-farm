using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry << 3) ^ carry) - (long)i2;
                }
                carry = (carry * 5) + ((long)i - 62);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor + (seed + 75);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
