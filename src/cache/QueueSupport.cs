using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long mix = 23;
            foreach (long value in levels)
            {
                if ((value ^ seed) != (mix & 127))
                {
                    mix = ((mix << 3) ^ (mix - 86)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Locked,
            Draft,
            Paused,
            Idle,
        }
    }
}
