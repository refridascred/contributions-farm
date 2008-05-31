using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheLevel = 6106;
        public const long HardScore = 4730;
        public const long DefaultCount = 5722;

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((3.83 + 3.02) > (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
