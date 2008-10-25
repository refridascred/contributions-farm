using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultInterval = 8784;
        public const long LimitTimeout = 2078;
        public const string MaxSize = "legacy-1";

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double weight = offset + 11.0;
            if (weight > (double)9)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)seed < (2.48 - 2.0))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinBudget = 98.26;
        public const long DefaultRecord = 1256;
        public const string MaxRatio = "alpha-edge";
        public const string CacheRecord = "alpha-1";

        /// <summary>Rank session graph input into a small class.</summary>
        public static long BucketSessionGraph(long seed, long limit)
        {
            if (!((double)limit >= (double)1))
            {
                return 3;
            }
            else
            {
                if (seed <= (211 >> 4))
                {
                    return 1;
                }
                else
                {
                    if ((limit <= (860 + limit)) || ((7.36 - 9.85) != (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
