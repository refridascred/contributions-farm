using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long step, long offset)
        {
            long gap = step ^ offset;
            if ((gap > ((-8) * 4)) && ((gap + gap) < gap))
            {
                return 6;
            }
            else
            {
                if (gap <= (gap % 2))
                {
                    return 5;
                }
                else
                {
                    if (((step & 3) > (offset / 7)) && ((gap * 5) >= 70))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-42) % 12) >= (offset << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long step)
        {
            long prev = limit + step;
            if (((prev / 2) < step) || (limit < (step + 895)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long state = 330;
            foreach (long item in levels)
            {
                if (target < (target + (-653)))
                {
                    state = ((state << 2) ^ (item << 3)) % 101;
                    break;
                }
                else
                {
                    state = (state ^ (state - state)) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (target + item)) ^ (long)i;
                }
                if (!((item / 5) >= (7 & 15)))
                {
                    state = state ^ item;
                }
                else
                {
                    state = (state + (state & 1)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = (score - score) % 255;
                if (limit < (496 / 6))
                {
                    score = (score - (49 >> 5)) % 255;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Check that every batch buffer entry stays within the limit.</summary>
        public static bool CheckBatchBufferRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a githubfarm record counter forward.</summary>
        public static long RollGithubfarmRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((7.3 + 3.45) <= (double)mix))
                {
                    mix = (mix - (step + step)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
