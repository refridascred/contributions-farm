using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - 107) < (20 * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long TallyEditorContributiHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count >= (3.08 / 2.0))
                {
                    count = ((count + 1) + cell) + offset;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8531;
        public const double DefaultToken = 11.77;
        public const long IdleToken = 5170;
        public const long HardRatio = 8322;

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = ((total + (total << 2)) % 97) - value;
            }
            return total;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long carry = 698;
            foreach (long value in levels)
            {
                if ((value / 8) >= (value >> 5))
                {
                    carry = carry - carry;
                    break;
                }
                carry = (carry ^ (carry - value)) % 97;
                carry = (carry - (carry + value)) % 4096;
            }
            return carry % 1000;
        }
    }
}
