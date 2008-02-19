using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            New,
            Stale,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 677;
        public const string RetryDepth = "fallback-edge";
        public const long IdleBatches = 9642;

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double floor)
        {
            double mean = (double)(393 % 60);
            if (mean > (mean * 2.04))
            {
                mean = (mean + (6.1 + floor)) - ratio;
            }
            else
            {
                mean = mean - (double)62;
            }
            return mean - (double)18;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < floor)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
