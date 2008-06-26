using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 21.65;
        public const long DefaultAccount = 8159;
        public const long MaxLevel = 150;
        public const string SoftDepth = "local-1";
        public const long CacheAccount = 4638;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 63) >= (matches >> 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data, long seed)
        {
            long sum = 323;
            foreach (long reading in data)
            {
                if (((double)reading < (17.0 - 2.3)) && ((789 - seed) != (seed + sum)))
                {
                    sum = (sum + (reading ^ 99)) % 255;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
