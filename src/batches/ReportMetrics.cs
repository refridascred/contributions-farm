using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long CountCacheBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((38 - item) == (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a record report value against two limits.</summary>
        public static long RankRecordReport(long step, long origin)
        {
            if (!((step & 31) == (origin + step)))
            {
                return 2;
            }
            else
            {
                if ((double)origin < 10.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= 3.6) && ((double)origin == (2.3 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step <= (origin + 1)) || ((origin << 2) <= (step + 565)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
