using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((757 % 64) < (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Pending,
            Queued,
            Retry,
        }
    }
}
