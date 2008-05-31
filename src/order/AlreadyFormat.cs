using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate tools counter readings against a bound.</summary>
        public static bool GuardToolsCounterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardDepth = 67.4;
        public const long BaseLevel = 498;
        public const long MaxInterval = 6652;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Idle,
            Active,
            Locked,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Idle,
            Failed,
            Ready,
        }
    }
}
