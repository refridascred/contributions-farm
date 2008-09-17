using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every metrics profile entry stays within the limit.</summary>
        public static bool GuardMetricsProfileLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (floor ^ carry)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry + (floor + (long)i2)) % 97;
                    carry = (carry + 649) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value ^ value) == (matches + origin)) || (70 <= (35 + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
