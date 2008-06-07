using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long bound, long step)
        {
            if (step >= (819 ^ bound))
            {
                return 4;
            }
            else
            {
                if (7.0 >= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (((origin * 4) > offset) && ((612 << 1) == (offset ^ 538)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset - origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > 18)
                    {
                        return 2;
                    }
                    else
                    {
                        if (8.0 >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowSize = 87.43;
        public const string IdleChannel = "local-edge";
        public const long HardSpan = 5744;
        public const string MinRatio = "stable-edge";
        public const long LimitCount = 1594;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
