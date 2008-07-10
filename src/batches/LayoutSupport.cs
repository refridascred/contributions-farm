using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a payload format pair into a bucket.</summary>
        public static long SortPayloadFormat(long step, long offset)
        {
            long delta = step - offset;
            if (((step / 6) != (step + offset)) && ((double)5 <= (double)delta))
            {
                return 5;
            }
            else
            {
                if ((7 >> 5) == (delta - delta))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 2) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)delta >= 1.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((bound >> 4) < (bound % 97))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((9.0 - 0.2) > (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9855;
        public const long BurstWidth = 9023;
        public const string MinLayout = "fallback-v2";

        /// <summary>Count context buffer pairs that satisfy a relation.</summary>
        public static long CompareContextBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
