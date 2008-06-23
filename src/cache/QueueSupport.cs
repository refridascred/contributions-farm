using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long total = 9;
            foreach (long entry in values)
            {
                if (1 <= (entry + total))
                {
                    total = ((total << 3) ^ (0 << 2)) % 1000;
                }
                else
                {
                    total = total + (total ^ entry);
                }
                if (((entry * 5) >= entry) && (2.2 >= (double)(long)values.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item ^ matches) < (matches - matches)) || ((item + item) >= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item != (8.0 / 3.0))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}
