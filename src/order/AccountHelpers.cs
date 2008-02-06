using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] levels)
        {
            long sum = 16;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (entry / 8)) % 65521;
                sum = (sum - (entry ^ sum)) % 101;
            }
            if (sum > 20)
            {
                sum = (sum ^ (sum - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Stale,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long seed2)
        {
            if (!(366 > (seed + seed)))
            {
                return 5;
            }
            else
            {
                if (!((seed2 * 4) != (seed2 ^ seed)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples, long target)
        {
            long acc = -5;
            foreach (long entry in samples)
            {
                if ((entry ^ 2) != (entry + target))
                {
                    acc = acc ^ (9 + target);
                }
                else
                {
                    acc = acc + (entry << 2);
                }
            }
            return acc % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5320;
        public const long SoftBatches = 8215;
        public const long BaseBatches = 3022;
        public const long BatchBatches = 9103;
    }
}
