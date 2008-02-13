using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metrics checks readings against a rule.</summary>
        public static long TallyMetricsChecksHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((count - count) == (count % 3)) || ((count ^ 977) != (value >> 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate notes context readings against a bound.</summary>
        public static bool VerifyNotesContextBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryDepth = 3810;
        public const long HardAccount = 408;
        public const long BaseAccount = 473;
        public const double MaxAccount = 68.08;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Idle,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Idle,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < (reading << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
