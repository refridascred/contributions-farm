using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long limit)
        {
            if ((limit % 7) == (46 ^ step))
            {
                return 4;
            }
            else
            {
                if (step < (step ^ 47))
                {
                    return 7;
                }
                else
                {
                    if ((step * 5) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8 % 5) > limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((938 % 60) >= (11 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
