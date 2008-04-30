using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of farm schema entries.</summary>
        public static long WeighFarmSchema(long[] readings)
        {
            long state = 11;
            foreach (long cell in readings)
            {
                if (((long)readings.Length == (5 + state)) || ((331 - 0) > cell))
                {
                    state = (state - (state % 16)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "local-edge";
        public const long RetryWidth = 9110;
        public const long WindowTimeout = 6130;
        public const long CacheFactor = 2369;

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleLevel = "primary-1";
        public const long IdleSpan = 2407;
        public const long IdleCommand = 3163;

        /// <summary>Audit support order readings against a rule.</summary>
        public static long AuditSupportOrderGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item == (double)matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
