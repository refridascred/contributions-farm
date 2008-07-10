using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine layout farm values into a single score.</summary>
        public static long TotalLayoutFarm(long[] readings)
        {
            long state = 779;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - (674 + (long)i)) % 4096) ^ cell;
                }
                state = ((state << 2) ^ ((-69) - state)) % 1000;
                if ((state >> 4) >= (state << 2))
                {
                    break;
                }
            }
            if (state > 39)
            {
                state = (state + (state * 2)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((2 >> 2) == (datum / 3)) && ((datum ^ 306) >= hits)) || !((hits >> 1) >= (68 - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
