using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next notes session value from a seed.</summary>
        public static long RollNotesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ (621 - carry)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 2) + (carry >> 5)) + (long)i2;
                }
                carry = carry ^ seed;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long MeasureChecksLayoutMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((4.0 - 7.0) < (double)value)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long limit, long bound)
        {
            long next = limit + bound;
            if ((bound ^ limit) <= 213)
            {
                return 8;
            }
            else
            {
                if ((14.0 / 6.0) == (double)next)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels)
        {
            long carry = 45;
            foreach (long item in levels)
            {
                if ((carry & 15) > (item & 7))
                {
                    carry = ((carry * 5) + (carry + 9)) % 1000;
                }
            }
            return carry;
        }
    }
}
