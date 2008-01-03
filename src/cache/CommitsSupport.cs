using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Retry,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Done,
            New,
            Active,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long seed)
        {
            if (((offset ^ offset) < 7) && ((seed ^ seed) <= (10 + seed)))
            {
                return 0;
            }
            else
            {
                if ((seed + 8) > offset)
                {
                    return 4;
                }
                else
                {
                    if ((seed - offset) >= (seed >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= (count + 745))
                {
                    count = ((count + 3) - sample) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
