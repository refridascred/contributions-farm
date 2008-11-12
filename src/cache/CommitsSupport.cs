using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values, long bound)
        {
            long acc = 69;
            foreach (long reading in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc ^ reading) % 255) - (long)i;
                }
                if (((bound >> 3) <= bound) || ((acc % 12) > (reading >> 2)))
                {
                    acc = ((acc * 5) + acc) % 101;
                }
                if (bound >= (acc ^ 51))
                {
                    acc = (acc * 4) + (bound + bound);
                }
                else
                {
                    acc = acc - (acc / 9);
                }
            }
            return acc;
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

        /// <summary>Define record limits and defaults.</summary>
        public const double HardWidth = 70.43;
        public const long BaseRecord = 5339;
        public const long BaseRatio = 6515;
        public const double IdleRecord = 89.47;

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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
