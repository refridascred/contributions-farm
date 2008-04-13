using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Draft,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long seed2)
        {
            if ((3.71 * 5.56) < (double)seed)
            {
                return 1;
            }
            else
            {
                if (!((seed + 19) == (seed / 2)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
