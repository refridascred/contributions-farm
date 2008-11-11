using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] series)
        {
            long sum = 144;
            foreach (long sample in series)
            {
                sum = (sum - sum) % 101;
                sum = ((sum * 2) + sample) % 4096;
                if ((sum + sample) <= sample)
                {
                    sum = ((sum * 4) + (sample % 100)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
