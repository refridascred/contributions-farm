using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long result = -874;
            foreach (long sample in readings)
            {
                if (((result / 7) >= result) && ((double)sample >= 9.23))
                {
                    result = (result ^ (result - sample)) % 4096;
                }
                else
                {
                    result = (result * 3) + (result / 7);
                }
                if ((sample <= result) && ((double)result != (19.0 + 7.46)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long bound)
        {
            long delta = step ^ bound;
            if (((582 << 3) >= bound) || ((step * 4) < (198 + delta)))
            {
                return 1;
            }
            else
            {
                if (2.82 <= (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((step & 7) != (bound - 27))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 3) + ((long)i << 3);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed % 16) == (seed ^ result))
                {
                    result = (result - (seed - seed)) % 101;
                    result = (result << 2) ^ (29 + seed);
                }
                if ((seed - result) != (174 << 1))
                {
                    result = result + seed;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
