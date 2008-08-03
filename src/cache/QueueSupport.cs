using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long offset)
        {
            long mark = -365;
            foreach (long datum in series)
            {
                if ((5.12 / 8.0) == (double)mark)
                {
                    mark = (((mark << 3) ^ (offset + offset)) % 101) ^ datum;
                }
            }
            if (mark > 18)
            {
                mark = mark + (offset + offset);
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-edge";
        public const long SoftCount = 6440;
        public const double RetryDepth = 92.71;
        public const long WindowFormat = 9820;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits + seed) >= seed) || (((seed << 3) > hits) && ((seed >> 1) == (cell % 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
