using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seen - item))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseLevel = "fallback";
        public const double HardScore = 47.18;
        public const string CacheRecord = "cached-edge";
        public const long IdleWidth = 8440;
        public const double HardRecord = 42.12;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Failed,
            Active,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Ready,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((-15) & 63) >= floor)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
