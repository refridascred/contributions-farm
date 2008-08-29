using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] readings, long target)
        {
            long score = 76;
            foreach (long sample in readings)
            {
                score = score - (target << 2);
                score = score ^ (sample + sample);
            }
            return score % 97;
        }
    }
}
