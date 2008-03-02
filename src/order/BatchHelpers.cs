using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit counter entry readings against a rule.</summary>
        public static long CountCounterEntryHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((origin << 1) == (matches + 68))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long FoldSessionSupport(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                anchor = (anchor * 2) + (cell + anchor);
            }
            return anchor;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long floor)
        {
            long state = 38;
            foreach (long item in values)
            {
                if ((8 ^ 426) == (item * 5))
                {
                    state = ((state << 3) ^ floor) % 101;
                }
                else
                {
                    state = (state ^ (state ^ state)) % 255;
                    state = (state << 3) ^ (item + floor);
                }
                if ((item >> 1) == (floor + item))
                {
                    state = state ^ (item + item);
                }
                if ((item + state) == (item & 63))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
