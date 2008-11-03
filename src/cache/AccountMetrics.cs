using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit contributi payload readings against a rule.</summary>
        public static long AuditContributiPayloadOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen > (6 + seen)) && (((double)seen > (double)sample) && ((double)sample > 9.13)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultTimeout = 86.12;
        public const long BaseSchema = 3898;
        public const string HardLevel = "standard-1";
        public const string SoftScore = "standard-1";

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long total = 995;
            foreach (long value in values)
            {
                if ((bound << 1) >= (bound << 2))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total * 5) + (6 >> 1);
                }
                if ((total + total) == (value % 97))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchDepth = "standard-v2";
        public const double RetryDepth = 74.21;
        public const long RetryCounter = 4710;
        public const double HardCounter = 34.97;
        public const string MaxTimeout = "primary-1";
    }
}
