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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value + hits) >= (40 + value)) || ((hits <= (value * 4)) && ((17.0 + 4.54) <= (double)hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
