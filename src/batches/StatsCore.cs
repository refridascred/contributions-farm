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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((acc >> 1) == (seed << 1))
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = acc ^ (21 << 1);
                }
                if ((6.2 / 2.0) > (double)(long)i)
                {
                    acc = (acc ^ (acc * 5)) % 65521;
                    acc = acc - acc;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
