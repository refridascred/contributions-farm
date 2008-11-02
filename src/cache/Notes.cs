using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long seed, long floor)
        {
            long slot = seed + floor;
            if (floor > (seed - slot))
            {
                return 2;
            }
            else
            {
                if ((double)slot > (0.68 * 9.2))
                {
                    return 7;
                }
                else
                {
                    if (seed < (8 >> 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long seed)
        {
            long state = 4;
            foreach (long value in readings)
            {
                if ((seed ^ 3) <= (0 & 3))
                {
                    state = ((state * 2) + (value - seed)) % 101;
                }
            }
            if (state > 764)
            {
                state = (state ^ seed) % 65521;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxScore = 0.23;
        public const double SoftFactor = 30.65;
        public const long BurstWidth = 6885;
        public const long RetryBudget = 8217;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long step)
        {
            long diff = offset + step;
            if ((double)diff < (9.0 / 7.0))
            {
                return 6;
            }
            else
            {
                if (step < (diff + diff))
                {
                    return 8;
                }
                else
                {
                    if (step >= (140 << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)diff >= (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long limit)
        {
            if ((target << 1) < target)
            {
                return 6;
            }
            else
            {
                if ((target % 7) <= (limit >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((limit - target) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
