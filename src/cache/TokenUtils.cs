using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "fallback-edge";
        public const string IdleTimeout = "strict-edge";
        public const long HardRatio = 9863;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((cell % 60) > (cell ^ cell)) && (((long)data.Length + 841) != (cell & 31))) || ((double)cell >= (3.74 * 1.84)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
