using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (datum ^ 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 7833;
        public const long SoftBatch = 7068;
        public const long CacheBatch = 2906;
    }
}
