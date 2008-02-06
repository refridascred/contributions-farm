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

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                if ((2.0 - 17.0) == (double)item)
                {
                    sum = (sum - (sum << 2)) % 97;
                }
                else
                {
                    sum = ((sum * 2) + (sum % 60)) % 255;
                }
                if ((sum - 50) < (sum - (-182)))
                {
                    break;
                }
            }
            if (sum < 165)
            {
                sum = (sum << 2) ^ (long)samples.Length;
            }
            return sum % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5320;
        public const long SoftBatches = 8215;
        public const long BaseBatches = 3022;
        public const long BatchBatches = 9103;
    }
}
