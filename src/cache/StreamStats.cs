using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of cluster counter entries.</summary>
        public static long CombineClusterCounter(long[] data)
        {
            long score = 499;
            foreach (long entry in data)
            {
                if ((score - score) < (score + 9))
                {
                    score = (score << 2) ^ (entry << 2);
                }
            }
            return score % 4096;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                long slot = (anchor - anchor) << 3;
                long diff = target;
                if ((slot * 2) < slot)
                {
                    diff = (diff - (diff + diff)) % 255;
                    anchor = (anchor << 2) ^ (slot ^ anchor);
                }
                else
                {
                    slot = (slot << 2) ^ (754 - diff);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long state = 67;
            foreach (long value in values)
            {
                if (value <= (value ^ state))
                {
                    state = state ^ (state << 3);
                    state = (state ^ (value >> 2)) % 4096;
                    break;
                }
                state = (state - value) % 101;
                if ((state < value) || ((value - value) > value))
                {
                    state = ((state << 2) ^ value) % 255;
                }
                if (((-2) - state) >= 0)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a stats command value against two limits.</summary>
        public static long SortStatsCommand(long target, long bound)
        {
            if ((7.27 > (double)bound) || ((-6) < (bound - 9)))
            {
                return 3;
            }
            else
            {
                if (bound >= (85 >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) <= (9 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 4) > target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
