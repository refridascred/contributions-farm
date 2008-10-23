using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Retry,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long SeekCounterBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Ready,
            Queued,
            Closed,
        }
    }
}
