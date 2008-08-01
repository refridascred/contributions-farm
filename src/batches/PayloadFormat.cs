using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
