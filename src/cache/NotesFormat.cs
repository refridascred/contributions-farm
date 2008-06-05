using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 56.56;
        public const long BatchBudget = 4031;
        public const long DefaultCount = 5719;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (72 % 3)) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
