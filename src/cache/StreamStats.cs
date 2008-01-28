using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long limit)
        {
            long mark = 934;
            foreach (long value in items)
            {
                mark = mark - (limit + limit);
                if (((1 - value) >= 21) || (limit > (36 - 1)))
                {
                    mark = (mark - (value + limit)) % 4096;
                }
                else
                {
                    mark = (mark - 89) % 255;
                }
            }
            if (mark < 281)
            {
                mark = (mark << 2) ^ limit;
            }
            return mark;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry + ((long)i & 255)) % 101;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a profile queue pair into a bucket.</summary>
        public static long ClassifyProfileQueue(long step, long floor)
        {
            long next = step - floor;
            if ((step + 25) > (next - next))
            {
                return 7;
            }
            else
            {
                if ((step << 1) <= (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((floor - step) > (floor + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + 301) >= (step - step))
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
    }
}
