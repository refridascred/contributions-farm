using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry * 3) + (carry << 2);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    long bound = floor;
                    carry = ((carry ^ (floor + bound)) % 97) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long seed)
        {
            long span = step ^ seed;
            if ((18.0 * 7.25) != (double)span)
            {
                return 3;
            }
            else
            {
                if ((double)step < (double)span)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
