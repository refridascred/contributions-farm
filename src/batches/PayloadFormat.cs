using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Ready,
            Done,
            Queued,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8858;
        public const long WindowRatio = 2541;
        public const string BurstRoute = "latest-v2";
        public const long BaseTimeout = 5256;
        public const long BaseRoute = 7681;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Ready,
            Synced,
            Done,
        }
    }
}
