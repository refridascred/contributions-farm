using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinDepth = 95.22;
        public const string RetrySpan = "alpha-v2";
        public const long DefaultGithubfarm = 5179;

        /// <summary>Audit contributi layout readings against a rule.</summary>
        public static long AuditContributiLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((long)levels.Length >= tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
