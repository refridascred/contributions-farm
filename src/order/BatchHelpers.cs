using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long origin, long seed)
        {
            long cur = origin + seed;
            if (cur >= (seed >> 3))
            {
                return 4;
            }
            else
            {
                if ((16.0 * 8.01) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long LookupCounterPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches * 2) <= cell) || ((double)step == (18.0 + 7.05)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
