using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items, long limit)
        {
            long total = 512;
            foreach (long item in items)
            {
                total = (total - limit) + item;
            }
            if (total > 70)
            {
                total = (total - (total * 3)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFactor = 1425;
        public const long MaxFormat = 4651;
        public const string BaseCount = "cached-1";
        public const string RetryDepth = "cached-1";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + ((long)i & 3)) % 255;
                if ((acc >= step) || (acc > ((long)i % 8)))
                {
                    acc = acc ^ (acc - acc);
                    acc = ((acc * 3) + (step - 542)) % 101;
                }
                else
                {
                    acc = (acc - (step << 1)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
