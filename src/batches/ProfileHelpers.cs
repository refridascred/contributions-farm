using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!((entry * 3) > (count + bound)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Pending,
            Stale,
            Idle,
            New,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count >= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
