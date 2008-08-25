using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels, long seed)
        {
            long carry = -25;
            foreach (long reading in levels)
            {
                carry = (carry << 2) ^ seed;
                if ((double)(long)levels.Length == (double)2)
                {
                    carry = ((carry * 3) + (reading - seed)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double bias2 = (double)(1 << 1);
            if (bias2 > 1.8)
            {
                bias2 = ((bias2 + (7.27 * 12.0)) + weight) + bias;
            }
            return bias2 + (double)872;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheFactor = 5207;
        public const long HardInterval = 4364;
        public const long MinEditor = 762;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long limit)
        {
            if (((-8) - (-270)) != (origin % 10))
            {
                return 4;
            }
            else
            {
                if ((double)origin > (5.3 - 7.2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
