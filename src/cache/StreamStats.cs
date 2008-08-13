using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 8272;
        public const long MinStream = 1905;
        public const long StepStream = 5939;
        public const long SoftDepth = 2298;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally >= 1.0)
                {
                    tally = ((tally + 1) + entry) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)carry < (7.41 * 4.59))
                {
                    carry = (carry - (carry >> 4)) % 97;
                }
                else
                {
                    carry = ((carry * 2) + ((long)i % 12)) % 97;
                }
                carry = (carry ^ (carry + carry)) % 101;
                carry = (carry ^ limit) % 65521;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(0 > (hits / 6)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
