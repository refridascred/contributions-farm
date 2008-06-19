using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ (result % 10);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 8163;
        public const long BurstProfile = 618;
        public const long StepProfile = 4691;
        public const long DefaultInterval = 5365;
    }
}
