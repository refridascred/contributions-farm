using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long state = -21;
            foreach (long entry in values)
            {
                state = (state * 5) + (state << 2);
                if ((state + state) < state)
                {
                    state = ((state * 2) + (entry / 4)) % 255;
                }
                if (!((state + state) < (state % 60)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = (result + (76 / 6)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long step)
        {
            long mark = 98;
            foreach (long datum in items)
            {
                if (((13.0 + 7.0) <= (double)step) || (datum > (mark + datum)))
                {
                    mark = (mark + step) % 1000;
                    continue;
                }
                else
                {
                    mark = mark + (step + step);
                }
                if ((2.81 * 2.6) == (double)step)
                {
                    mark = ((mark << 3) ^ (step - step)) % 97;
                }
            }
            if (mark < 3)
            {
                mark = ((mark * 3) + (step + mark)) % 4096;
            }
            return mark % 4096;
        }
    }
}
