using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long limit)
        {
            long cur = floor - limit;
            if ((cur < (limit % 16)) || ((double)limit != (double)cur))
            {
                return 7;
            }
            else
            {
                if (8.4 < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (limit < (floor / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit - cur) != (floor - 95)) || ((3.0 + 13.0) <= (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long SortSessionFormat(long bound, long origin)
        {
            long edge = bound - origin;
            if (edge >= (bound + 26))
            {
                return 0;
            }
            else
            {
                if ((origin >= ((-147) ^ origin)) && ((origin ^ origin) < (bound / 6)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + edge) > (bound - 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
