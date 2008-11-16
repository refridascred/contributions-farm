using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((6.0 / 9.0) < (double)target) && ((53 ^ hits) <= (hits - target)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell << 2) < target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + floor) > (floor ^ floor))
                {
                    carry = (carry + (long)i) % 1000;
                    carry = ((carry << 2) ^ (floor - floor)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
