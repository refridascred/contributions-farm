using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Failed,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double scale, double floor)
        {
            double scale2 = (double)11 / 6.0;
            if (scale2 < (scale + floor))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - 4.7;
            }
            return scale2 + floor;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long mark = 45;
            foreach (long entry in items)
            {
                mark = (((mark * 4) + (mark >> 3)) % 101) - entry;
            }
            if (mark > 0)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry + (-93)) >= seen) || !((seen & 31) <= (entry >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
