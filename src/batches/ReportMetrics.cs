using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultTimeout = 6656;
        public const string SoftDepth = "open-v2";
        public const long DefaultEntry = 3423;
        public const string HardTimeout = "cached-v2";

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ ((long)i % 100);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
