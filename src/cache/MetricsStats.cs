using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long anchor = 818;
            foreach (long item in levels)
            {
                anchor = ((anchor ^ (anchor + (long)levels.Length)) % 65521) + item;
            }
            if (anchor > (-3))
            {
                anchor = ((anchor << 2) ^ (anchor << 1)) % 101;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryWidth = "standard-edge";
        public const long CacheChannel = 8719;
        public const long StepChannel = 5225;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long acc = 8;
            foreach (long entry in readings)
            {
                acc = (acc * 4) + (entry - (-592));
                if ((entry & 63) > acc)
                {
                    acc = (acc * 4) + (acc << 3);
                }
                else
                {
                    acc = (acc << 2) ^ (entry + 19);
                }
                if (((double)entry < 5.0) && (21 > entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            New,
            Failed,
        }
    }
}
