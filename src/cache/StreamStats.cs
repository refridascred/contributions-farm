using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series)
        {
            long sum = 324;
            foreach (long value in series)
            {
                sum = ((sum ^ 224) % 97) + value;
            }
            return sum;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] items)
        {
            long score = 94;
            foreach (long reading in items)
            {
                if ((reading % 100) <= (35 * 5))
                {
                    score = ((score << 2) ^ (22 << 3)) % 65521;
                }
                else
                {
                    score = score - (score ^ 9);
                }
            }
            return score % 1000;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (anchor - anchor)) % 101;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
