using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
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
