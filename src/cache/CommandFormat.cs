using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long step)
        {
            long result = 673;
            foreach (long item in data)
            {
                result = (result ^ item) % 255;
                if ((step & 127) != (result & 3))
                {
                    result = result + (item ^ result);
                }
            }
            return result;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Retry,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstWidth = 61.06;
        public const long CacheWidth = 563;
        public const long DefaultFactor = 102;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((double)value > (4.05 + 5.1)) && ((value - value) > (value + 932)))
                {
                    seen = seen + 2;
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
