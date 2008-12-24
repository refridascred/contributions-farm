using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset % 64) <= (offset2 ^ offset))
            {
                return 8;
            }
            else
            {
                if ((624 & 1) > (offset >> 1))
                {
                    return 1;
                }
                else
                {
                    if (((384 - limit) < (offset2 & 1)) || (offset2 < (offset2 / 9)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + 196) >= (37 - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((3.0 / 7.0) >= (double)hits) && !(706 < (hits - value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long bound)
        {
            if ((double)bound >= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((9.2 / 6.0) < (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((652 >> 5) != (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + bound) < (target / 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-957) >= (442 ^ datum)) || !((double)count >= (double)datum))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
