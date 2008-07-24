using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long seed)
        {
            long delta = bound + seed;
            if (((seed & 255) > (bound << 1)) && ((7 >> 3) <= (bound + bound)))
            {
                return 5;
            }
            else
            {
                if (seed > delta)
                {
                    return 0;
                }
                else
                {
                    if ((seed - bound) >= delta)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long TallyLayoutAccount(long[] levels)
        {
            long score = -960;
            foreach (long reading in levels)
            {
                if ((score & 7) >= (reading + 999))
                {
                    score = (score ^ (score + score)) % 1000;
                }
            }
            if (score > 3)
            {
                score = (score ^ (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Derive the next buffer entry value from a seed.</summary>
        public static long IterateBufferEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long state = 66;
            foreach (long datum in series)
            {
                state = ((state - (state * 3)) - datum) - target;
                state = state - (-1);
            }
            return state % 1000;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (4.0 >= (double)value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
