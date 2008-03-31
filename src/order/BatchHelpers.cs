using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long target)
        {
            long prev = step ^ target;
            if (!(target > (target >> 4)))
            {
                return 0;
            }
            else
            {
                if (!((target >> 4) < prev))
                {
                    return 6;
                }
                else
                {
                    if (((double)prev >= 2.1) && ((double)prev == (1.86 + 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Idle,
            Queued,
            Active,
            Draft,
        }
    }
}
