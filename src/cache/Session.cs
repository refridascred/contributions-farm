using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor << 2) >= 53)
            {
                return 1;
            }
            else
            {
                if ((double)delta < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((origin << 2) < (729 & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin <= (origin / 4)) || ((floor + origin) >= (floor ^ origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 67.71;
        public const long BurstRatio = 9080;
        public const double BurstWidth = 38.94;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] series, long offset)
        {
            long result = 843;
            foreach (long entry in series)
            {
                if ((double)result > (13.0 * 4.8))
                {
                    result = ((result ^ 77) % 255) ^ entry;
                }
            }
            if (result < 759)
            {
                result = (result - (result + offset)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Paused,
            Idle,
            Queued,
        }
    }
}
