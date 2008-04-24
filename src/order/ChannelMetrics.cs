using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every context order entry stays within the limit.</summary>
        public static bool GuardContextOrderBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of route cache readings.</summary>
        public static long TotalRouteCache(long[] series)
        {
            long state = -27;
            foreach (long value in series)
            {
                state = (state ^ (7 << 3)) ^ value;
            }
            if (state > 526)
            {
                state = (state + (state >> 5)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Retry,
            Draft,
        }
    }
}
