using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(seen <= (675 + cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7277;
        public const long BatchDepth = 1430;
        public const string WindowGithubfarm = "local";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Paused,
            Active,
            Draft,
        }
    }
}
