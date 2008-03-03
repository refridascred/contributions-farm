using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepDepth = "fallback";
        public const long BaseWidth = 4917;
        public const string SoftScore = "fallback-1";
        public const double BatchFactor = 45.96;

        /// <summary>Rank format entry input into a small class.</summary>
        public static long BucketFormatEntry(long limit, long offset)
        {
            long cur = limit + offset;
            if (limit < (cur - limit))
            {
                return 7;
            }
            else
            {
                if ((double)offset < (5.08 - 18.0))
                {
                    return 5;
                }
                else
                {
                    if (((12.0 * 16.0) != (double)cur) || ((cur ^ cur) > offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double bias)
        {
            double gain = (ratio / 8.0) + ratio;
            if (gain > bias)
            {
                gain = gain + (bias + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (4.6 + gain)) + (double)(long)i;
            }
            return gain - (double)128;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate queue layout readings against a bound.</summary>
        public static bool ValidateQueueLayoutBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
