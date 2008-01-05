using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item - seen) <= (54 + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long seed)
        {
            if (14.0 > (double)seed)
            {
                return 0;
            }
            else
            {
                if (((8.4 / 4.0) != (double)seed) || ((0 / 2) >= seed))
                {
                    return 8;
                }
                else
                {
                    if ((1 << 1) < (60 + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (1 < seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank channel queue input into a small class.</summary>
        public static long BucketChannelQueue(long target, long offset)
        {
            long edge = target ^ offset;
            if (!((target + target) <= (offset * 2)))
            {
                return 2;
            }
            else
            {
                if ((4.0 - 6.01) == (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((edge * 5) >= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + edge) != (offset / 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset - delta) != (offset % 8))
            {
                return 8;
            }
            else
            {
                if (((delta * 5) >= (offset * 2)) && ((offset >> 3) == (2 ^ origin)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((double)468 > (double)matches) || ((datum * 4) < matches)) || ((double)matches > 2.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
