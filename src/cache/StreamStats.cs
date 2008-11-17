using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Synced,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Pending,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (4.2 > (double)result)
                {
                    result = ((result * 3) + (result + 72)) % 255;
                    result = (result * 4) + (result << 2);
                }
                else
                {
                    result = result + (floor + 7);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
