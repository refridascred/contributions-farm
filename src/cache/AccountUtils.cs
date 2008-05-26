using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats token value from a seed.</summary>
        public static long DeriveStatsToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = result - offset;
                result = ((result << 3) ^ (result + (-3))) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Idle,
            Dropped,
            Retry,
        }
    }
}
