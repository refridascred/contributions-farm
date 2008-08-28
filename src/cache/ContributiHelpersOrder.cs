using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLevel = 6846;
        public const long BurstLayout = 4195;
        public const long SoftCount = 7497;
        public const long HardLayout = 4320;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series)
        {
            long total = 4;
            foreach (long datum in series)
            {
                if ((datum * 4) <= (datum - datum))
                {
                    total = (total << 2) ^ (86 - total);
                }
            }
            if (total > (-3))
            {
                total = ((total * 3) + (total / 7)) % 97;
            }
            return total;
        }
    }
}
