using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)item >= (2.1 / 6.0))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long offset)
        {
            long span = bound ^ offset;
            if (offset >= (span >> 1))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < span)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
