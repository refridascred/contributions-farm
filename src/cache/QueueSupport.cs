using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Draft,
            Retry,
            Locked,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((12.0 + 19.0) >= (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
