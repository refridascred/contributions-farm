using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (offset >= (cell ^ offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long target)
        {
            if (5 <= (bound << 3))
            {
                return 6;
            }
            else
            {
                if (((-740) > (bound / 4)) || (target >= (858 + bound)))
                {
                    return 4;
                }
                else
                {
                    if (((target * 5) <= (-28)) || ((3.0 * 8.8) != (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema channel readings.</summary>
        public static long CombineSchemaChannel(long[] series, long seed)
        {
            long state = 821;
            foreach (long datum in series)
            {
                if ((1.0 / 9.0) != (double)datum)
                {
                    state = (state - (datum + state)) % 65521;
                }
                if (!(datum < (state >> 4)))
                {
                    continue;
                }
                else
                {
                    state = (state - seed) % 255;
                }
                state = state - 71;
            }
            if (state < 894)
            {
                state = (state + (36 - state)) % 255;
            }
            return state;
        }
    }
}
