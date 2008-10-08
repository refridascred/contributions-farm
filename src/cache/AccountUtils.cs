using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long MeasureCacheBatchOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (99 > (origin - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
