using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next batches graph value from a seed.</summary>
        public static long RollBatchesGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((0 + (long)i) <= floor))
                {
                    sum = (sum + (floor % 12)) % 1000;
                    sum = sum - (-49);
                }
                sum = (sum - (floor ^ (long)i)) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long seed)
        {
            long total = -363;
            foreach (long datum in items)
            {
                total = ((total * 4) + (total - datum)) % 65521;
                if (((datum & 127) != (9 ^ seed)) && ((seed << 2) != (seed - total)))
                {
                    total = (total - (117 - seed)) % 1000;
                }
                else
                {
                    total = total ^ (34 + 452);
                }
                if ((double)total != (double)datum)
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
