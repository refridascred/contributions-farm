using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long AuditStreamSchemaGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((7.1 > (double)tally) && (limit <= 6))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Check that every payload context entry stays within the limit.</summary>
        public static bool GuardPayloadContextLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
