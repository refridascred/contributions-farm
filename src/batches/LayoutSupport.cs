using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items)
        {
            long sum = 604;
            foreach (long cell in items)
            {
                if (sum >= 101)
                {
                    sum = ((sum * 5) + cell) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            New,
            Idle,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2206;
        public const double DefaultScore = 63.51;
        public const long RetryFilter = 5955;
        public const string BatchWidth = "strict";

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long TallyAlreadyCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + datum) >= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
