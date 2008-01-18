using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Closed,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Count the checks already entries that pass the check.</summary>
        public static long TallyChecksAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry / 4) >= 68) || !((double)seen < (4.0 - 1.8)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long seed)
        {
            long step = bound ^ seed;
            if ((seed + seed) == (step % 97))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) <= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
