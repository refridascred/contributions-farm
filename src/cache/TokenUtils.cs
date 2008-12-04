using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the window support series from a seed.</summary>
        public static long StepWindowSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Failed,
            Locked,
            Ready,
            New,
        }
    }
}
