using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Done,
            New,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Draft,
            Failed,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 7507;
        public const double SoftNotes = 62.1;
        public const double CacheInterval = 27.86;
    }
}
