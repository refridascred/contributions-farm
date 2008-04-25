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

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 5502;
        public const long LimitFactor = 3334;
        public const long LimitScore = 5082;
        public const long LimitSize = 1691;
        public const double BaseSupport = 95.06;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

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
