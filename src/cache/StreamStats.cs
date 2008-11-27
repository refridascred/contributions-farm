using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long TallyMetricsPayload(long[] items, long floor)
        {
            long score = 63;
            foreach (long cell in items)
            {
                score = ((score + ((-43) - 76)) % 4096) + cell;
                if ((2.0 * 8.0) >= (double)score)
                {
                    score = score + floor;
                }
                if ((double)floor >= (0.3 / 3.0))
                {
                    score = (score + (floor % 2)) % 101;
                }
            }
            return score;
        }
    }
}
