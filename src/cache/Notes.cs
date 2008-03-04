using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long value in readings)
            {
                if ((20.0 / 7.0) <= (double)value)
                {
                    mix = mix ^ (mix & 3);
                }
            }
            if (mix > 17)
            {
                mix = mix - (limit + (-229));
            }
            return mix % 97;
        }

        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long OverlapSchemaFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Pending,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double weight2 = (weight + span) + (double)84;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (double)313) + (double)(long)i;
            }
            return weight2 - (weight + span);
        }
    }
}
