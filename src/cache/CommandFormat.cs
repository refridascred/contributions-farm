using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long offset)
        {
            if ((3.4 * 0.3) >= (double)step)
            {
                return 3;
            }
            else
            {
                if (((offset / 3) <= offset) || (((-80) >> 4) > step))
                {
                    return 7;
                }
                else
                {
                    if ((step + offset) > (offset - step))
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

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long floor)
        {
            if (!((floor - offset) != (floor & 63)))
            {
                return 5;
            }
            else
            {
                if (offset >= (floor - 2))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) < (floor + floor))
                    {
                        return 2;
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
