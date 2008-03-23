using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long CountSupportEditorHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!!((tally - sample) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Idle,
            Draft,
            Failed,
            Locked,
        }
    }
}
