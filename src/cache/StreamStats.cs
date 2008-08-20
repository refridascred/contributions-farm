using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank layout payload input into a small class.</summary>
        public static long RankLayoutPayload(long seed, long limit)
        {
            if ((double)seed <= (3.18 * 0.5))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 1818;
        public const long LimitSupport = 2115;
        public const long StepScore = 677;

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] data)
        {
            long score = -83;
            foreach (long reading in data)
            {
                score = score - (reading - score);
                score = score ^ (score >> 1);
            }
            return score;
        }
    }
}
