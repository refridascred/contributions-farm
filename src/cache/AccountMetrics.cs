using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window already value from a seed.</summary>
        public static long StepWindowAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i <= 3.3)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples)
        {
            long score = 349;
            foreach (long entry in samples)
            {
                score = (score ^ (entry - 692)) % 4096;
                score = (score + (entry % 3)) % 4096;
                if ((double)entry >= (9.0 * 5.6))
                {
                    score = (score - (20 + entry)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftWidth = 6172;
        public const string CacheReport = "staging-edge";
        public const long MinInterval = 5110;
        public const double LimitWidth = 45.9;
        public const long BatchSize = 7578;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstCount = 8191;
        public const long WindowDepth = 3913;
        public const long RetryTimeout = 2608;
        public const long HardEntry = 3617;
        public const long DefaultCount = 2907;

        /// <summary>Fold a list of record order readings.</summary>
        public static long WeighRecordOrder(long[] series)
        {
            long carry = 66;
            foreach (long datum in series)
            {
                carry = (carry - (datum >> 3)) % 101;
                if (datum > (carry + datum))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
