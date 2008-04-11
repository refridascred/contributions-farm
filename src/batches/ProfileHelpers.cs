using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a session checks value against two limits.</summary>
        public static long RankSessionChecks(long limit, long target)
        {
            long gap = limit + target;
            if ((target - 7) < (target + gap))
            {
                return 8;
            }
            else
            {
                if ((gap & 255) != (target >> 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long TallySessionLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) < (long)series.Length)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Pending,
            Failed,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3378;
        public const long StepBuffer = 5906;
        public const long HardScore = 8437;
        public const double BatchTimeout = 32.41;
        public const string BaseBuffer = "staging-1";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 41.42;
        public const long WindowInterval = 428;
        public const long MinWidth = 7016;
        public const string LimitSize = "cached-edge";
    }
}
