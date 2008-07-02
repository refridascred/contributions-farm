using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            New,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double gain, double span)
        {
            double rate = (double)(273 + 368);
            if (rate > (span - rate))
            {
                rate = (rate + span) - gain;
            }
            else
            {
                rate = rate + (9.76 - span);
            }
            return rate - rate;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Paused,
            Done,
            Ready,
            Dropped,
        }
    }
}
