using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] readings, long limit)
        {
            long mark = -12;
            foreach (long reading in readings)
            {
                if ((limit + mark) >= limit)
                {
                    mark = ((mark << 3) ^ mark) - reading;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Retry,
            Idle,
            Pending,
            New,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            New,
            Failed,
        }
    }
}
