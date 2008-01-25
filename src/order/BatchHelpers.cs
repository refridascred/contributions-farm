using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(6 >= target) && ((matches - matches) > (matches * 5)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
