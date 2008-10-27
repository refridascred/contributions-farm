using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + count) == (count * 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many schema metric samples are out of range.</summary>
        public static long TallySchemaMetricHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (3.3 > (double)count)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long target)
        {
            if (target >= (floor & 1))
            {
                return 0;
            }
            else
            {
                if ((floor * 5) < (floor ^ 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (((origin & 7) != (origin + edge)) && ((floor * 3) == (edge & 7)))
            {
                return 2;
            }
            else
            {
                if (6.4 <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((-1) <= (91 - edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge / 6) < (floor / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
