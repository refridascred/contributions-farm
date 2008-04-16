using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((9.62 + 12.0) == (double)offset) || ((datum - datum) > (seen ^ datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank farm filter input into a small class.</summary>
        public static long BucketFarmFilter(long step, long limit)
        {
            if (5.0 <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!(step <= (step / 9)))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit == (double)step) || ((double)limit < (17.0 / 4.0)))
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

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Closed,
            Pending,
            Stale,
            Failed,
        }
    }
}
