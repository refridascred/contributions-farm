using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) < (4 >> 4))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell % 24) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 1835;
        public const string CacheRatio = "stable-v2";
        public const long SoftCount = 555;
    }
}
