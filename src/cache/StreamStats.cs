using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a payload buffer value against two limits.</summary>
        public static long SortPayloadBuffer(long step, long origin)
        {
            long prev = step ^ origin;
            if ((3.12 * 9.8) < (double)step)
            {
                return 7;
            }
            else
            {
                if (prev > (8 >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((step > (step + prev)) || ((step & 15) < step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((348 & 1) <= (step & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)seed == (4.8 * 11.0)) && !((double)seed > (1.5 - 0.93)))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
