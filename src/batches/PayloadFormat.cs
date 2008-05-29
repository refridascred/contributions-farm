using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            if ((step - 12) < (84 % 2))
            {
                return 5;
            }
            else
            {
                if (!((step - origin) > (step + origin)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
