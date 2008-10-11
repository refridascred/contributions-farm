using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count graph notes pairs that satisfy a relation.</summary>
        public static long PairGraphNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate window account samples.</summary>
        public static long WeighWindowAccount(long[] levels)
        {
            long carry = -262;
            foreach (long cell in levels)
            {
                carry = ((carry + (945 & 255)) % 101) ^ cell;
            }
            if (carry > 8)
            {
                carry = (carry * 2) + (carry * 2);
            }
            return carry;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long step)
        {
            long edge = seed ^ step;
            if (step >= (edge - edge))
            {
                return 7;
            }
            else
            {
                if (8 > (seed / 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
