using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Queued,
            New,
            Ready,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Idle,
            New,
            Ready,
            Draft,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset + offset) <= offset)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
