using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCount = 8728;
        public const long HardSpan = 5345;
        public const long MinBudget = 9568;
        public const long StepCluster = 1144;
        public const string LimitInterval = "standard";

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long AuditFilterContributiOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((target + target) > target)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + count) < count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
