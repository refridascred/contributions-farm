using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits checks value from a seed.</summary>
        public static long IterateCommitsChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i >= 6)
                {
                    sum = sum ^ (offset / 5);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long seed)
        {
            long diff = bound ^ seed;
            if ((seed & 127) >= (946 - bound))
            {
                return 1;
            }
            else
            {
                if (5 <= bound)
                {
                    return 8;
                }
                else
                {
                    if ((diff % 64) > (bound << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (diff < (5 >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long mark = 537;
            foreach (long cell in data)
            {
                if ((double)limit > 3.78)
                {
                    mark = ((mark * 5) + cell) % 101;
                }
            }
            if (mark > 68)
            {
                mark = mark + 394;
            }
            return mark % 97;
        }
    }
}
