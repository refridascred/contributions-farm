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

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (double)5)
            {
                scale2 = (scale2 + scale2) + scale;
            }
            return scale2 - bias;
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
