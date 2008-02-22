using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen % 16) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 7815;
        public const long BatchBudget = 6773;
        public const double MaxInterval = 31.54;

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long floor)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = (acc * 5) + 7;
                acc = (acc << 2) ^ (entry / 6);
                acc = acc ^ ((-904) - 569);
            }
            if (acc > (-427))
            {
                acc = (acc << 3) ^ (floor ^ acc);
            }
            return acc;
        }
    }
}
