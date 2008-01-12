using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinScore = 5493;
        public const long HardProfile = 1071;
        public const long BaseDepth = 2786;

        /// <summary>Measure how many filter metric samples are out of range.</summary>
        public static long MeasureFilterMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(seen > (cell - cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long score = 71;
            foreach (long sample in items)
            {
                if (!(sample < bound))
                {
                    score = score - (bound - score);
                }
                else
                {
                    score = score ^ score;
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long target)
        {
            if ((offset / 5) != (492 % 24))
            {
                return 8;
            }
            else
            {
                if ((double)target >= (9.0 * 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 5) == ((-637) + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
