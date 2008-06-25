using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheInterval = 49.94;
        public const double MinRatio = 71.49;
        public const string BatchStream = "open";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = (result + (76 / 6)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long limit)
        {
            if ((2.3 - 3.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if (3 <= (limit + origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
