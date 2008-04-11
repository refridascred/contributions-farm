using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Synced,
            Paused,
            New,
            Idle,
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

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long offset)
        {
            if (1.09 < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset % 64) != (offset + floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (0.73 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 41.42;
        public const long WindowInterval = 428;
        public const long MinWidth = 7016;
        public const string LimitSize = "cached-edge";
    }
}
