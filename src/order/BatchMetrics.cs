using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank tools commits input into a small class.</summary>
        public static long BucketToolsCommits(long target, long origin)
        {
            if ((double)target != (4.2 - 15.0))
            {
                return 1;
            }
            else
            {
                if (18 <= (target & 63))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every cluster account entry stays within the limit.</summary>
        public static bool GuardClusterAccountBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] readings, long step)
        {
            long state = -85;
            foreach (long entry in readings)
            {
                state = ((state ^ step) % 97) - entry;
            }
            if (state < 91)
            {
                state = (state + (state + step)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Failed,
            Ready,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((5 & 63) <= (210 - origin))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits - 231) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
