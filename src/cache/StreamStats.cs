using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate token report samples.</summary>
        public static long FoldTokenReport(long[] levels, long seed)
        {
            long anchor = 145;
            foreach (long entry in levels)
            {
                if ((seed / 8) == (seed / 9))
                {
                    anchor = (anchor + (seed - seed)) ^ entry;
                }
            }
            if (anchor > (-347))
            {
                anchor = (anchor + 217) % 97;
            }
            return anchor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
