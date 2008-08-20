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

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
