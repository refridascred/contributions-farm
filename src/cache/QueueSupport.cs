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

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
