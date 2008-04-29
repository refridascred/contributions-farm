using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxScore = 4177;
        public const long LimitWidth = 4823;
        public const double WindowLevel = 36.47;
        public const double BurstDepth = 78.88;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long ClassifyCommandRecord(long origin, long bound)
        {
            if ((1.2 * 8.57) == (double)origin)
            {
                return 0;
            }
            else
            {
                if ((double)bound == (3.77 + 1.8))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
