using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Failed,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((931 % 5) == (datum ^ datum)) && !((datum + 632) >= count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
