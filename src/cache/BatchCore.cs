using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((18.0 - 20.0) >= (double)count) || ((double)seed == (0.1 - 5.5)))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 39.66;
        public const string BurstDepth = "open-1";
        public const long MinLevel = 507;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Compare every pair of tools batches readings.</summary>
        public static long CompareToolsBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
