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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
