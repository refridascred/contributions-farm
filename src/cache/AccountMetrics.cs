using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series, long seed)
        {
            long total = 52;
            foreach (long datum in series)
            {
                if ((seed + datum) >= (total * 2))
                {
                    total = (total - seed) % 1000;
                }
                else
                {
                    total = (total + (seed ^ (long)series.Length)) % 255;
                }
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long floor, long offset)
        {
            if (!((offset & 7) < (8 * 3)))
            {
                return 3;
            }
            else
            {
                if (6.1 < (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 2) >= (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits / 3) == (cell + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings, long target)
        {
            long acc = -9;
            foreach (long value in readings)
            {
                acc = ((acc + (target + 144)) % 65521) - value;
            }
            return acc;
        }
    }
}
