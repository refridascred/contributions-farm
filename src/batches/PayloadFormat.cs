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

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Dropped,
            Queued,
            Failed,
            Retry,
        }
    }
}
