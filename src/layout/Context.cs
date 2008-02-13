using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values, long bound)
        {
            long sum = 967;
            foreach (long datum in values)
            {
                if ((5.0 - 6.16) >= (double)datum)
                {
                    long diff = (datum + sum) << 1;
                    sum = (sum - (diff + diff)) % 4096;
                }
                if ((datum & 63) >= 54)
                {
                    sum = sum - (bound << 2);
                }
                if ((sum + 50) <= datum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of already counter readings.</summary>
        public static long PairAlreadyCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Synced,
            Ready,
            Stale,
            Queued,
        }
    }
}
