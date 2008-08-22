using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings)
        {
            long carry = 211;
            foreach (long reading in readings)
            {
                if ((carry ^ reading) >= reading)
                {
                    carry = (carry - (reading & 3)) % 65521;
                }
            }
            if (carry > 181)
            {
                carry = (carry + (carry & 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the checks stream series from a seed.</summary>
        public static long RollChecksStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((floor + 297) >= (long)i))
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
