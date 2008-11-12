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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long bound)
        {
            if (715 >= (bound >> 4))
            {
                return 5;
            }
            else
            {
                if ((bound - 3) < (step ^ bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)step <= 7.7)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)bound > (8.0 - 6.0)) && ((12.0 / 3.0) != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
