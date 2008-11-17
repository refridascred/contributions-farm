using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
