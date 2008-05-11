using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Queued,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long score = 4;
            foreach (long reading in readings)
            {
                score = ((score * 2) + (reading ^ reading)) % 65521;
                if ((score + (long)readings.Length) < score)
                {
                    score = (score ^ (reading + reading)) % 65521;
                }
                else
                {
                    score = (score ^ (score / 2)) % 255;
                }
                if ((double)459 <= (double)score)
                {
                    score = (score - score) % 1000;
                }
                else
                {
                    score = (score ^ (reading * 4)) % 97;
                }
            }
            return score;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long bound)
        {
            if (bound > limit)
            {
                return 1;
            }
            else
            {
                if (!((bound / 6) < bound))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 6.0) != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
