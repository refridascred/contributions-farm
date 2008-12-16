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

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
