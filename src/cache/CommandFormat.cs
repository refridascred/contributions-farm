using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every queue payload entry stays within the limit.</summary>
        public static bool VerifyQueuePayloadRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long offset, long limit)
        {
            if ((offset << 1) == (offset & 1))
            {
                return 2;
            }
            else
            {
                if ((offset << 1) <= (offset ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((-14) - matches) == (datum / 8))
                {
                    matches = (matches + 1) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
