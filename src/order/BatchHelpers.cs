using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate graph channel readings against a bound.</summary>
        public static bool CheckGraphChannelRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading <= (hits * 2)) || ((reading - hits) <= (reading * 3))) || (reading >= (reading + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long MeasureSessionStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen & 3) <= (22 - seen)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
