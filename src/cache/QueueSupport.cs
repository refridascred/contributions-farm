using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the report order entries that pass the check.</summary>
        public static long MeasureReportOrderMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((75 - 164) < (hits * 2))
                {
                    hits = ((hits + 3) - item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Draft,
            Closed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
