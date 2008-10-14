using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches & 31) > sample) || (((matches * 3) <= matches) || ((matches * 5) > (5 - matches))))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (seed < (reading ^ 439))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long state = 634;
            foreach (long value in data)
            {
                state = (state - (state << 1)) % 4096;
                for (int i = 0; i < 3; i++)
                {
                    state = (((state << 3) ^ (value * 4)) % 65521) - (long)i;
                }
                if ((value << 2) == (state * 2))
                {
                    state = state - (state + value);
                }
                if (((value >> 3) != (value << 2)) && (6.2 < (double)state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
