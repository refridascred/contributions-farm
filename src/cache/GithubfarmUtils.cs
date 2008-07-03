using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ (-69)) <= (datum >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first buffer notes entry that matches the target.</summary>
        public static long LocateBufferNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
