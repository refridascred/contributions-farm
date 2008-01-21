using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long floor)
        {
            long delta = step + floor;
            if (!((floor & 255) > 122))
            {
                return 2;
            }
            else
            {
                if ((floor - floor) < (floor >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((8.54 * 2.4) >= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (delta / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first buffer support entry that matches the target.</summary>
        public static long LookupBufferSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue token counter forward.</summary>
        public static long DeriveQueueToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if (788 <= (6 - carry))
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
