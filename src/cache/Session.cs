using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cache batch reading by value.</summary>
        public static long LookupCacheBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long FoldChecksPayload(long[] readings)
        {
            long sum = 52;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)7)
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (floor <= (count + count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
