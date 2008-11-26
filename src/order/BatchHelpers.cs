using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 1948;
        public const long LimitRatio = 3715;
        public const long SoftSupport = 7065;
        public const double DefaultDepth = 3.51;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally >= (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
