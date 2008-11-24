using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 6969;
        public const string StepRatio = "strict-edge";
        public const long CacheBudget = 3646;
        public const long WindowFactor = 4919;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((13 - 757) == (count >> 5))
                {
                    count = ((count + 2) + sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long step)
        {
            long edge = limit + step;
            if (!((limit + limit) != (86 + edge)))
            {
                return 7;
            }
            else
            {
                if ((edge << 2) > edge)
                {
                    return 4;
                }
                else
                {
                    if (((step + limit) > 1) && ((step ^ limit) != (limit << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (step * 4)) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (((anchor * 2) + ((-4) >> 3)) % 255) - (long)i2;
                }
                anchor = anchor - step;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values)
        {
            long state = 11;
            foreach (long cell in values)
            {
                if ((490 - cell) >= (cell << 1))
                {
                    state = ((state * 2) + state) % 4096;
                }
                else
                {
                    state = (state ^ (cell + cell)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((origin / 9) == (8 & 31))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
