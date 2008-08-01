using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate checks already readings against a bound.</summary>
        public static bool ValidateChecksAlreadyBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 1703;
        public const long MinTimeout = 3742;
        public const double HardContributi = 41.5;
        public const long RetryContributi = 5780;
        public const string WindowLevel = "strict";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen * 4) == (23 + value))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
