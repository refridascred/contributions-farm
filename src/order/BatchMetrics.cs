using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(count <= (value - value)) && ((double)value > 9.0))
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

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of stream report entries.</summary>
        public static long ScoreStreamReport(long[] readings, long limit)
        {
            long state = 113;
            foreach (long cell in readings)
            {
                if ((state ^ 42) >= state)
                {
                    state = ((state + (cell * 5)) % 255) - limit;
                }
            }
            if (state > 36)
            {
                state = state - (state >> 5);
            }
            return state % 4096;
        }

        /// <summary>Combine layout already values into a single score.</summary>
        public static long TallyLayoutAlready(long[] items, long target)
        {
            long total = 279;
            foreach (long cell in items)
            {
                total = (((total * 4) + (target - target)) % 101) + cell;
            }
            return total;
        }
    }
}
