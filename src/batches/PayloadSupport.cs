using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of support metric readings.</summary>
        public static long CombineSupportMetric(long[] readings, long seed)
        {
            long state = 24;
            foreach (long cell in readings)
            {
                if ((cell << 2) <= state)
                {
                    state = ((state * 5) + (9 + 3)) % 101;
                }
                if ((cell - state) != (cell + seed))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
