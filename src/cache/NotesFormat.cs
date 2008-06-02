using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long bound)
        {
            long lane = origin - bound;
            if ((lane >> 3) >= (bound * 2))
            {
                return 8;
            }
            else
            {
                if ((origin ^ lane) > (bound / 7))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Queued,
            Closed,
        }
    }
}
