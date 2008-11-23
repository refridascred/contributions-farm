using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((double)sample >= (0.8 / 3.0)) && ((origin < (seen - sample)) && ((seen * 3) < (86 & 63))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Draft,
            Paused,
        }
    }
}
