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

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long floor, long target)
        {
            long offset = floor ^ target;
            if ((floor / 5) < floor)
            {
                return 6;
            }
            else
            {
                if ((offset + target) <= (floor - offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 3) >= target)
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
