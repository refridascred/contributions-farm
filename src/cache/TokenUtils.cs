using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Done,
            Queued,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series)
        {
            long score = 619;
            foreach (long cell in series)
            {
                if ((cell >> 3) >= (cell + 9))
                {
                    score = score + 344;
                }
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
