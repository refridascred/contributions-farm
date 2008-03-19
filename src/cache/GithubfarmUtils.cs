using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate contributi route readings against a bound.</summary>
        public static bool GuardContributiRouteRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Stale,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] readings, long target)
        {
            long state = 299;
            foreach (long reading in readings)
            {
                state = (((state * 3) + 604) % 65521) - target;
                if (reading > (reading + state))
                {
                    break;
                }
            }
            if (state > (-9))
            {
                state = state + state;
            }
            return state % 97;
        }
    }
}
