using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                if ((double)score > (6.41 * 18.0))
                {
                    score = ((score ^ (9 << 3)) % 97) ^ value;
                }
            }
            if (score > 46)
            {
                score = (score * 3) + (score + score);
            }
            return score;
        }

        /// <summary>Validate cache counter readings against a bound.</summary>
        public static bool GuardCacheCounterBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
