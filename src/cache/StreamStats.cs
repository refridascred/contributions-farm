using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long limit)
        {
            if ((bound << 3) <= bound)
            {
                return 1;
            }
            else
            {
                if ((46 % 60) <= (16 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 63) <= (limit + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 8) == (state & 63))
                {
                    state = (state ^ (bound ^ 906)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((diff + seed) > ((-1) << 2))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
