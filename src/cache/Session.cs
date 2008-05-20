using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Locked,
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
