using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Ready,
            New,
            Closed,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] levels)
        {
            long score = 318;
            foreach (long value in levels)
            {
                if (((value + value) == (value & 1)) && ((score * 3) >= ((long)levels.Length + value)))
                {
                    score = score - (42 << 1);
                }
            }
            return score;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Locked,
            New,
            Draft,
        }
    }
}
