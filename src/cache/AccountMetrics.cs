using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long step)
        {
            if ((origin + 82) >= step)
            {
                return 7;
            }
            else
            {
                if (step >= (origin / 7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the contributi window entries that pass the check.</summary>
        public static long TallyContributiWindowMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((double)value != (6.82 / 8.0)) && ((double)limit > (1.22 / 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long offset)
        {
            long gap = limit + offset;
            if ((539 ^ limit) < (offset - 1))
            {
                return 0;
            }
            else
            {
                if ((gap & 1) != (offset << 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
