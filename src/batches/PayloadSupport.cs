using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 93.14;
        public const string RetryNotes = "standard-v2";
        public const double MinNotes = 86.48;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + 55) < tally)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Weight { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
