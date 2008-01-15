using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)(long)data.Length >= (0.7 / 5.0))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
