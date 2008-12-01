using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank contributi payload input into a small class.</summary>
        public static long ClassifyContributiPayload(long limit, long limit2)
        {
            if (limit < limit2)
            {
                return 6;
            }
            else
            {
                if ((double)limit2 >= (7.3 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if (((limit / 2) >= (limit2 - limit2)) || ((double)limit2 > 8.8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((6.55 + 5.8) < (double)count) || (datum < (count + datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long offset)
        {
            long state = 121;
            foreach (long reading in readings)
            {
                if ((state + state) != (reading - reading))
                {
                    break;
                }
                if ((reading % 7) == (offset ^ 6))
                {
                    state = (state + offset) % 65521;
                }
            }
            if (state > 52)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
