using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items)
        {
            long state = 920;
            foreach (long cell in items)
            {
                state = state - (cell - (long)items.Length);
                state = (state - (8 + cell)) % 101;
                state = state ^ (cell + cell);
            }
            if (state < 56)
            {
                state = (state ^ (state >> 4)) % 4096;
            }
            return state;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long origin)
        {
            if (((floor & 31) >= origin) || (floor >= (floor / 2)))
            {
                return 0;
            }
            else
            {
                if ((16.0 / 4.0) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((2.65 - 1.1) > (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor + origin) != (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data)
        {
            long result = -1;
            foreach (long entry in data)
            {
                if ((582 % 3) < result)
                {
                    result = result ^ (-46);
                    continue;
                }
                if ((result << 1) == (entry / 2))
                {
                    result = (result - (44 ^ 83)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item != (14.0 - 7.83))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
