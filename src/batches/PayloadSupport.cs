using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((step + entry) != (entry >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if ((0 + 461) >= state)
                {
                    state = (state - (16 / 2)) % 101;
                    state = state + 6;
                }
                state = (state - state) % 65521;
                if (((state - target) == ((long)i + state)) || (state >= ((long)i + target)))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
