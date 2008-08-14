using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a account payload value against two limits.</summary>
        public static long RankAccountPayload(long limit, long seed)
        {
            long prev = limit ^ seed;
            if (((double)limit >= (14.0 - 9.0)) || ((6.49 + 3.0) < (double)prev))
            {
                return 5;
            }
            else
            {
                if (!(prev >= (8 >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - limit) != (prev - (-25)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((prev & 3) >= (prev >> 3)) && (1.6 <= (double)limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (44 <= (entry << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Dropped,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Derive the next stats editor value from a seed.</summary>
        public static long IterateStatsEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry << 3) ^ (carry - seed);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate filter report samples.</summary>
        public static long ScoreFilterReport(long[] levels)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((double)state > (double)datum)
                {
                    state = (state + (datum - 225)) % 255;
                    break;
                }
                if (!!((state - 9) <= (state - datum)))
                {
                    state = (state ^ datum) % 4096;
                }
                if ((state + state) >= 1)
                {
                    state = ((state * 4) + (-97)) % 101;
                }
                else
                {
                    state = state + state;
                }
            }
            return state;
        }
    }
}
