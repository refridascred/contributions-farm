using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Active,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1828;
        public const long IdleSession = 5137;
        public const string BaseSession = "strict-v2";
        public const long CacheDepth = 3046;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) >= 733)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
