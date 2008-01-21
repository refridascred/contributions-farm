using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Pending,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Combine schema notes values into a single score.</summary>
        public static long CombineSchemaNotes(long[] series)
        {
            long mix = 0;
            foreach (long item in series)
            {
                mix = mix + (item - item);
            }
            return mix;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
