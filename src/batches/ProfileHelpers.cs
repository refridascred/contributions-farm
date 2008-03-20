using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < (double)count)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((-6) % 10) <= (entry % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinWidth = 44.27;
        public const string RetryMetric = "stable-edge";
        public const long MaxDepth = 6601;
        public const double HardSpan = 42.62;
        public const long MinMetric = 1000;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftScore = 22.96;
        public const long WindowWidth = 651;
        public const double BaseSchema = 73.31;
        public const string RetrySchema = "cached";
        public const long IdleSchema = 5990;
    }
}
