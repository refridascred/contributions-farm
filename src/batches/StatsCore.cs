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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample << 1) > (count ^ 581))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((7.71 - 2.4) < (double)value)
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultCount = "cached-1";
        public const string IdleSpan = "cached-edge";
        public const string HardBatches = "latest-edge";
        public const long HardInterval = 1728;
    }
}
