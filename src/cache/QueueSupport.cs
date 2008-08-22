using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowTimeout = 2127;
        public const long HardSpan = 4484;
        public const double BurstTimeout = 38.81;

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

        /// <summary>Look up the position of a route cache sample.</summary>
        public static long SeekRouteCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
