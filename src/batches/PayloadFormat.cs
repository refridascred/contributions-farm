using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                if (!!((bound & 7) < anchor))
                {
                    anchor = (anchor - (7 + (-3))) % 1000;
                    anchor = anchor ^ (bound * 3);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Dropped,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Locked,
            Ready,
            Draft,
        }
    }
}
