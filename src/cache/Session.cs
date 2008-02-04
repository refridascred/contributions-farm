using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Ready,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Active,
            Failed,
        }

        /// <summary>Find the first token session entry that matches the target.</summary>
        public static long FindTokenSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
