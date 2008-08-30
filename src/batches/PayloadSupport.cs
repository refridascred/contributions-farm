using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 2) + origin) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter entry pair into a bucket.</summary>
        public static long ClassifyCounterEntry(long step, long target)
        {
            if (step >= (target >> 2))
            {
                return 6;
            }
            else
            {
                if (!(step <= target))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target) > 4)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
