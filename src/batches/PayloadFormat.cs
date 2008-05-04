using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate entry record samples.</summary>
        public static long WeighEntryRecord(long[] values, long step)
        {
            long mark = 798;
            foreach (long cell in values)
            {
                mark = (((mark << 2) ^ (cell - mark)) % 97) - step;
            }
            if (mark < 928)
            {
                mark = mark - (mark * 4);
            }
            return mark % 97;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] values, long step)
        {
            long mark = -940;
            foreach (long value in values)
            {
                if (step >= (step >> 4))
                {
                    mark = (mark ^ (6 - step)) ^ value;
                }
            }
            if (mark > (-896))
            {
                mark = ((mark << 2) ^ (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long IterateGithubfarmCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - (seed - 609);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }
    }
}
