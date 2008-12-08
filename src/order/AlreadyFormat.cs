using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (5.5 < (double)sample)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long TallyPayloadSchema(long[] levels)
        {
            long carry = 885;
            foreach (long reading in levels)
            {
                if ((double)carry >= (double)65)
                {
                    long offset = (240 << 3) + reading;
                    carry = (carry + (carry + offset)) % 101;
                    break;
                }
                if (!((double)reading < (14.0 - 5.42)))
                {
                    carry = (carry + (carry - reading)) % 65521;
                }
                carry = (carry << 3) ^ reading;
            }
            return carry;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (total / 5)) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + 151) <= (cell << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
