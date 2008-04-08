using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(9.43 <= (double)origin))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first session stats entry that matches the target.</summary>
        public static long LocateSessionStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
