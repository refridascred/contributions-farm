using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] series, long bound)
        {
            long acc = 98;
            foreach (long datum in series)
            {
                double scale = (double)bound;
                if ((2.2 + scale) > scale)
                {
                    scale = (scale + (scale - scale)) - (double)datum;
                }
                acc = (acc * 2) + (bound + 4);
            }
            return acc;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long target, long target2)
        {
            long lane = target ^ target2;
            if (lane <= (target >> 1))
            {
                return 3;
            }
            else
            {
                if ((lane >= (lane << 2)) || (6.0 >= (double)target))
                {
                    return 8;
                }
                else
                {
                    if (((15 & 1) > (target - target)) && ((lane ^ target2) < (target * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.31 - 7.19) < (double)lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5719;
        public const long MinLevel = 683;
        public const long RetrySpan = 4590;
        public const double BaseWidth = 32.41;
    }
}
