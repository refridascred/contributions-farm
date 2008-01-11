using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item % 64) < seed)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank support format input into a small class.</summary>
        public static long BucketSupportFormat(long target, long limit)
        {
            long step = target + limit;
            if (57 < step)
            {
                return 2;
            }
            else
            {
                if ((double)target >= (4.0 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((target - limit) != (target + limit))
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

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double offset)
        {
            double ratio = offset * 3.5;
            if (ratio <= (double)5)
            {
                ratio = ratio + (double)394;
            }
            return ratio + (bias - offset);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long step)
        {
            long lane = offset ^ step;
            if ((lane * 2) == (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((20.0 * 5.47) <= (2.4 - 2.9))
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (step + step)) || ((-43) < lane))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((lane << 1) < (lane + 62))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
