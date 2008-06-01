using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long IterateClusterFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((bound - bound) != ((long)i >> 1)) && ((20 + bound) <= 4))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state - (bound * 3)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate tools commits samples.</summary>
        public static long TallyToolsCommits(long[] items, long target)
        {
            long score = 8;
            foreach (long sample in items)
            {
                if (((double)sample == (5.47 / 2.0)) || ((double)target != (20.0 * 3.68)))
                {
                    score = ((score << 3) ^ (sample >> 3)) % 1000;
                }
                if ((3.47 / 6.0) >= (double)target)
                {
                    score = score - (sample + target);
                }
            }
            if (score < 949)
            {
                score = score + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchInterval = 5867;
        public const long IdleFactor = 4967;
        public const string WindowRecord = "legacy";
        public const double WindowSpan = 40.28;
        public const long LimitWidth = 8208;
    }
}
