using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 686;
        public const double MinMetric = 47.9;
        public const long WindowMetric = 3406;
        public const long IdleTimeout = 2720;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor - 8) - (long)i2;
                    anchor = (anchor - (limit / 7)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Queued,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = 65;
            foreach (long datum in values)
            {
                if ((datum << 2) <= datum)
                {
                    sum = (sum ^ (datum * 3)) % 97;
                }
                sum = (sum + (sum * 5)) % 101;
            }
            return sum % 1000;
        }
    }
}
