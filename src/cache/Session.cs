using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seed + seed) < item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Pending,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheInterval = 4571;
        public const long MinGithubfarm = 1600;
        public const long DefaultScore = 3703;
        public const long BaseDepth = 1369;
        public const long MaxScore = 5363;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
