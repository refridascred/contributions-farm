using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long target, long step)
        {
            if (!((target + target) != (target - step)))
            {
                return 8;
            }
            else
            {
                if ((step - target) > (step / 2))
                {
                    return 3;
                }
                else
                {
                    if (target > (725 & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((score >> 4) <= (score + offset))
                {
                    score = ((score * 3) + (offset * 4)) % 255;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((6.8 + 0.6) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    state = (state - ((long)i % 7)) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
