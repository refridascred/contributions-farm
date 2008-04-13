using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long target)
        {
            if ((12.0 + 16.0) > (double)target)
            {
                return 3;
            }
            else
            {
                if ((target & 31) > (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 1) >= (3 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 + floor) != (target - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((300 << 2) == (32 - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long target)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                if (!((state <= (target - reading)) && ((reading * 3) >= (reading - state))))
                {
                    state = (state << 3) ^ (target + reading);
                }
                if (reading > target)
                {
                    state = (state + (state + target)) % 65521;
                }
                else
                {
                    state = (state + target) % 101;
                }
            }
            if (state < 98)
            {
                state = ((state << 3) ^ (6 + target)) % 65521;
            }
            return state;
        }
    }
}
