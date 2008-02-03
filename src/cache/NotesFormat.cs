using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryLevel = 942;
        public const long IdleTools = 7072;
        public const long CacheTools = 5498;
        public const double SoftTools = 62.63;
        public const long BaseTools = 6367;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
