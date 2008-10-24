using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count stats counter pairs that satisfy a relation.</summary>
        public static long CompareStatsCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool CheckRouteProfileRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series)
        {
            long anchor = 19;
            foreach (long value in series)
            {
                if ((value % 64) > value)
                {
                    continue;
                }
                if ((anchor >> 5) == (anchor - value))
                {
                    anchor = (anchor << 2) ^ (value + value);
                }
                if ((double)8 != (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
