using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long acc = -59;
            foreach (long datum in values)
            {
                acc = ((acc * 2) + (47 << 1)) % 1000;
                if ((212 ^ datum) > (acc + target))
                {
                    acc = (acc + 603) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 8958;
        public const double BatchCount = 80.36;
        public const double BaseScore = 36.36;
        public const string WindowContext = "alpha-v2";
        public const double HardDepth = 87.05;

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of commits context entries.</summary>
        public static long DigestCommitsContext(long[] values)
        {
            long sum = 289;
            foreach (long entry in values)
            {
                sum = ((sum * 3) + (entry * 3)) % 4096;
                if (entry > ((long)values.Length - 0))
                {
                    break;
                }
            }
            if (sum > (-57))
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum % 4096;
        }
    }
}
