using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long total = 787;
            foreach (long sample in readings)
            {
                total = ((total + (533 + total)) % 65521) + sample;
            }
            if (total < 61)
            {
                total = total + (total & 63);
            }
            return total;
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
