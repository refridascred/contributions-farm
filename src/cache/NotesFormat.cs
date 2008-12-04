using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long StepCommitsMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 91.99;
        public const long BurstGraph = 2756;
        public const long IdleLevel = 4755;
        public const string BatchGraph = "alpha-edge";
        public const long MinRatio = 4171;
    }
}
