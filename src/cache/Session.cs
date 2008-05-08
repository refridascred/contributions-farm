using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long state = 15;
            foreach (long entry in series)
            {
                state = ((state ^ (state / 6)) % 4096) + entry;
            }
            return state;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
