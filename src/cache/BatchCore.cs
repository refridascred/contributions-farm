using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if ((origin % 10) > seed)
            {
                return 8;
            }
            else
            {
                if (!((6.1 * 7.5) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (!((seed - origin) >= (5 & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) > (origin + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data, long step)
        {
            long mix = 789;
            foreach (long cell in data)
            {
                mix = ((mix << 2) ^ 21) - step;
                if (154 > (mix & 127))
                {
                    mix = mix - (mix >> 1);
                }
                else
                {
                    mix = (mix ^ cell) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
