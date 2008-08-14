using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long total = 5;
            foreach (long item in items)
            {
                if ((item - 741) > (total - total))
                {
                    total = ((total << 3) ^ item) % 255;
                }
                if ((double)total < (5.58 + 6.0))
                {
                    break;
                }
            }
            if (total < 0)
            {
                total = (total * 3) + total;
            }
            return total % 65521;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix * 5) + mix;
                for (int i3 = 0; i3 < 2; i3++)
                {
                    mix = (mix - (mix ^ (long)i3)) % 255;
                    mix = (mix * 5) + mix;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultCount = "cached-1";
        public const string IdleSpan = "cached-edge";
        public const string HardBatches = "latest-edge";
        public const long HardInterval = 1728;
    }
}
