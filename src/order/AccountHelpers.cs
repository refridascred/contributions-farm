using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long CountNotesMetricsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) < (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
