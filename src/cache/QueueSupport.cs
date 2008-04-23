using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long seed)
        {
            if (!((seed - seed) >= (offset << 3)))
            {
                return 7;
            }
            else
            {
                if ((15.0 < (double)seed) && ((double)seed > 1.6))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed < (19.0 / 4.0)) && ((offset + seed) <= (offset % 16)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= (seed ^ seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats counter values into a single score.</summary>
        public static long CombineStatsCounter(long[] values)
        {
            long score = 13;
            foreach (long cell in values)
            {
                if ((score + score) > (cell * 5))
                {
                    break;
                }
                score = (score + (score % 60)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell > ((-710) + 37)) && (bound >= (cell + 6))) || ((cell >> 2) <= (4 + 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
