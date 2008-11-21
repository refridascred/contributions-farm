using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitScore = 84.09;
        public const long DefaultLevel = 2999;
        public const long LimitContributi = 3378;

        /// <summary>Fold a list of stats stream readings.</summary>
        public static long FoldStatsStream(long[] items, long target)
        {
            long acc = 786;
            foreach (long value in items)
            {
                if ((acc - value) >= ((-207) - target))
                {
                    acc = (acc << 3) ^ value;
                }
            }
            if (acc > (-1))
            {
                acc = (acc ^ (3 ^ target)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count & 255) < (39 << 2)) && ((cell ^ 6) <= cell))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
