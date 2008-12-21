using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSize = 1108;
        public const long RetryCounter = 1220;
        public const long MaxCounter = 3970;

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long bound)
        {
            long score = 859;
            foreach (long reading in levels)
            {
                score = ((score ^ (score * 4)) + reading) + bound;
            }
            if (score > 463)
            {
                score = (score * 2) + (-39);
            }
            return score;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
