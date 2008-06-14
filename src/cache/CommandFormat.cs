using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 3689;
        public const double HardEditor = 63.41;
        public const long MaxEditor = 3813;
        public const string RetryEditor = "latest-v2";

        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long CountReportChecksGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)sample > (double)count) || ((112 * 3) >= (sample & 255)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
