using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseTimeout = 5308;
        public const double CacheFilter = 73.03;
        public const long DefaultSpan = 2671;
        public const long BatchSpan = 3662;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((866 ^ count) > (50 + cell)) || (count >= cell))
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

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleTimeout = "latest-1";
        public const long StepInterval = 9702;
        public const long DefaultProfile = 9631;
        public const double MaxInterval = 71.23;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long target)
        {
            long score = 9;
            foreach (long entry in series)
            {
                if ((double)score >= (6.0 * 6.0))
                {
                    score = ((score + entry) % 255) + target;
                }
            }
            return score;
        }
    }
}
