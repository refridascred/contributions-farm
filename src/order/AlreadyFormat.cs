using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a window context figure with a bias.</summary>
        public static double AdjustWindowContext(double ratio, double span)
        {
            double mean = 18.0 - ratio;
            return (mean + 12.0) + span;
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long SeekCacheNotesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Idle,
            Failed,
            Ready,
        }
    }
}
