using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a entry contributi reading by value.</summary>
        public static long LookupEntryContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((double)acc < (14.0 / 3.0)) || (seed >= (7 * 2)))
                {
                    acc = ((acc << 2) ^ (acc & 15)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings)
        {
            long result = 5;
            foreach (long item in readings)
            {
                result = ((result - (result + result)) % 97) - item;
            }
            if (result < 1)
            {
                result = ((result << 2) ^ (result - result)) % 255;
            }
            return result;
        }
    }
}
