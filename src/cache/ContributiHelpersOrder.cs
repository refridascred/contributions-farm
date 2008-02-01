using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long offset)
        {
            if (3.0 >= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit * 4) <= (7 & 3))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (6.1 / 4.0)) || (offset < (limit + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset * 4) != (offset * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long target)
        {
            long cur = offset - target;
            if ((double)target != (6.8 - 1.2))
            {
                return 6;
            }
            else
            {
                if (target < (-130))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset >= (double)cur)
                    {
                        return 5;
                    }
                    else
                    {
                        if (4.0 >= (double)cur)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ (mark / 6);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ (mark * 4)) % 97) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
