using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 3389;
        public const long StepScore = 5517;
        public const long RetryCount = 5975;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (4.0 <= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((1.0 - 6.0) <= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
