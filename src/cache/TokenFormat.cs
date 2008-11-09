using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Idle,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] levels)
        {
            long anchor = 824;
            foreach (long reading in levels)
            {
                anchor = (anchor + (reading << 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long floor)
        {
            long score = -2;
            foreach (long datum in readings)
            {
                if ((11 + datum) > (score + score))
                {
                    score = (score - (score + floor)) % 65521;
                }
            }
            return score;
        }
    }
}
