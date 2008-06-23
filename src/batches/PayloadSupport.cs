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

        /// <summary>Find the first stats payload entry that matches the target.</summary>
        public static long LookupStatsPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
