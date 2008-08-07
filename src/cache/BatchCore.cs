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

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((mix - seed) <= (mix ^ 90))
                {
                    mix = mix - mix;
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix * 4) + mix) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
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
