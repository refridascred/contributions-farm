using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item ^ item) < (item + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Queued,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile counter entry stays within the limit.</summary>
        public static bool ValidateProfileCounterBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
