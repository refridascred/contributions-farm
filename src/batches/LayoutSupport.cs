using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxInterval = "latest-v2";
        public const long WindowCounter = 4561;
        public const string StepCounter = "fallback";
        public const long SoftCounter = 1199;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 1473;
        public const long DefaultCommits = 3601;
        public const long BaseBudget = 9318;
        public const long RetryCommits = 8131;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Closed,
            New,
            Stale,
            Pending,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
