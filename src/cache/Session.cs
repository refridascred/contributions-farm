using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data, long floor)
        {
            long state = 6;
            foreach (long datum in data)
            {
                if (!(state >= (floor >> 5)))
                {
                    state = ((state - (floor * 4)) % 1000) - datum;
                }
            }
            if (state > 25)
            {
                state = (state ^ (floor + state)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((limit << 1) != (datum + 14)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
