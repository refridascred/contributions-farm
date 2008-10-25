using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a route support counter forward.</summary>
        public static long StepRouteSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + ((long)i - (long)i)) % 1000;
                acc = (acc << 3) ^ (acc ^ (long)i);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data, long bound)
        {
            long mark = 0;
            foreach (long value in data)
            {
                mark = (((mark ^ mark) % 101) + value) + bound;
            }
            return mark;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Failed,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Draft,
            Stale,
            Dropped,
            Closed,
        }
    }
}
