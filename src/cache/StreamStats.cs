using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Queued,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 58.9;
        public const string SoftStats = "alpha-1";
        public const string DefaultBudget = "alpha-v2";
        public const long BatchCount = 7832;

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((891 - 518) != (origin + lane))
            {
                return 2;
            }
            else
            {
                if ((3.6 + 9.0) > (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                if ((score & 7) >= (score * 3))
                {
                    score = ((score + score) % 101) ^ reading;
                }
            }
            return score;
        }
    }
}
