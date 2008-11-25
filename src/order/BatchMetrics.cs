using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items)
        {
            long score = 1;
            foreach (long cell in items)
            {
                score = score - cell;
            }
            return score;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples, long target)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                if ((-704) > (target - target))
                {
                    acc = (acc + (292 % 8)) + item;
                }
                else
                {
                    acc = ((acc << 3) ^ (target & 31)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] values, long bound)
        {
            long carry = -7;
            foreach (long value in values)
            {
                if (17 <= (value / 8))
                {
                    carry = ((carry << 2) ^ (value << 1)) % 255;
                }
                else
                {
                    carry = (carry ^ 6) % 4096;
                }
            }
            if (carry > 844)
            {
                carry = ((carry << 2) ^ (carry + bound)) % 4096;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 9585;
        public const double BaseTimeout = 86.8;
        public const double StepStats = 7.52;
        public const long HardStats = 2840;
        public const string BaseRatio = "open";

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Derive the next stats counter value from a seed.</summary>
        public static long IterateStatsCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry << 3) ^ 34;
                carry = carry ^ (5 + carry);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
