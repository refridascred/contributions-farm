using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = mix ^ (seed / 6);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits << 3) != (7 + hits))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftDepth = 2056;
        public const long IdleWidth = 8750;
        public const long StepDepth = 1289;
    }
}
