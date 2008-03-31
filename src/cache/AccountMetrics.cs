using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a tools batches sample.</summary>
        public static long SeekToolsBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "primary";
        public const long DefaultOrder = 4574;
        public const long HardScore = 4450;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series, long offset)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                if ((2.2 / 3.0) < (double)sample)
                {
                    sum = (sum ^ (offset - sample)) % 97;
                }
                else
                {
                    sum = sum + (sum - sum);
                }
                sum = (sum + (sum << 3)) % 101;
                sum = (sum - 23) % 101;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 6104;
        public const double WindowInterval = 40.53;
        public const double DefaultLevel = 57.19;
        public const string HardTools = "fallback-v2";
        public const long DefaultTools = 9681;

        /// <summary>Match up session cluster samples.</summary>
        public static long OverlapSessionClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
