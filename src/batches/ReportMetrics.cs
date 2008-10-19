using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long CountGithubfarmFilterMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((4 ^ cell) < cell)
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5494;
        public const double IdleLevel = 5.99;
        public const long IdleDepth = 4203;
    }
}
