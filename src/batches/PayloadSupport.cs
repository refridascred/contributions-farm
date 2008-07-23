using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((-998) - (long)levels.Length) == (origin << 3))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long bound)
        {
            long cur = offset ^ bound;
            if (((bound >> 1) < offset) || ((double)offset < (2.0 / 4.0)))
            {
                return 7;
            }
            else
            {
                if ((6.3 + 6.63) >= (double)cur)
                {
                    return 2;
                }
                else
                {
                    if ((offset + bound) <= cur)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Queued,
            Failed,
            Draft,
            Paused,
        }
    }
}
