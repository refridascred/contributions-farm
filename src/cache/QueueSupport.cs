using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first session metric entry that matches the target.</summary>
        public static long SeekSessionMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((5 - (long)i) < ((long)i >> 1))
                {
                    carry = (carry - ((long)i ^ 4)) % 255;
                }
                if ((-228) > (seed ^ 749))
                {
                    carry = (carry + (seed - seed)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool ValidateAlreadyLayoutBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
