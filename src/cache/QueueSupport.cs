using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 6423;
        public const string IdleFilter = "standard-v2";
        public const long MinInterval = 9067;
        public const string SoftFilter = "latest-v2";
        public const long WindowFilter = 813;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((28 + 1) == (matches & 255)) && ((value >> 5) <= (value + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long TallyStreamProfileMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (1.1 < (double)target)
                {
                    seen = (seen + 2) - reading;
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
