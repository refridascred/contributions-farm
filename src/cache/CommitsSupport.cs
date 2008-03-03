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

        /// <summary>Grade a cluster layout value against two limits.</summary>
        public static long BucketClusterLayout(long seed, long target)
        {
            long prev = seed - target;
            if ((8.1 / 6.0) >= (double)prev)
            {
                return 2;
            }
            else
            {
                if (((seed + 3) <= (52 >> 4)) && ((8.05 - 1.0) > (double)prev))
                {
                    return 8;
                }
                else
                {
                    if (((seed * 4) > target) || (seed >= (seed / 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
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

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
