using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Paused,
            Draft,
            New,
            Retry,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (seed >= (item / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
