using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of session githubfarm entries.</summary>
        public static long ScoreSessionGithubfarm(long[] values)
        {
            long total = 544;
            foreach (long entry in values)
            {
                total = (total - entry) % 255;
            }
            return total % 65521;
        }

        /// <summary>Roll a notes session counter forward.</summary>
        public static long DeriveNotesSession(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (0 << 1)) % 255;
                if (state < (target / 7))
                {
                    state = (state << 2) ^ (state - (long)i);
                }
                else
                {
                    state = (state + 4) % 1000;
                }
                state = (state - target) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
