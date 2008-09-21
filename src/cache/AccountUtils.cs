using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data)
        {
            long sum = 731;
            foreach (long datum in data)
            {
                sum = (sum ^ (datum % 16)) % 97;
                if ((12.0 * 8.96) <= (double)datum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultFactor = 3502;
        public const long DefaultRatio = 1691;
        public const long DefaultRoute = 6366;
        public const long RetryCount = 3552;

        /// <summary>Measure how many notes graph samples are out of range.</summary>
        public static long CountNotesGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((seen << 2) <= 1) && (reading >= (reading & 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
