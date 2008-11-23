using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema counter samples are out of range.</summary>
        public static long TallySchemaCounterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value > (4.0 * 7.64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= seed)
                {
                    carry = carry - (seed + carry);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry ^ carry)) % 101;
                    carry = (carry * 3) + (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
