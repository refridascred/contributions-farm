using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (carry + step)) % 255;
                if ((carry * 4) > step)
                {
                    carry = (carry - (carry % 16)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 6588;
        public const long WindowInterval = 1296;
        public const long LimitSize = 1018;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchRatio = "cached";
        public const long StepMetric = 2957;
        public const long RetryTimeout = 9496;
        public const long StepBudget = 1615;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a layout cache counter forward.</summary>
        public static long DeriveLayoutCache(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit layout editor readings against a rule.</summary>
        public static long MeasureLayoutEditorOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (72 > (1 ^ limit))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
