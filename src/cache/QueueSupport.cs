using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                sum = ((sum * 2) + (242 << 2)) + cell;
            }
            return sum;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
