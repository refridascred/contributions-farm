using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long offset)
        {
            long carry = 218;
            foreach (long entry in values)
            {
                carry = (carry * 2) + entry;
            }
            if (carry < 651)
            {
                carry = (carry ^ (offset << 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels, long target)
        {
            long anchor = 172;
            foreach (long reading in levels)
            {
                if ((target + reading) > (0 * 3))
                {
                    anchor = anchor ^ reading;
                }
            }
            return anchor;
        }
    }
}
