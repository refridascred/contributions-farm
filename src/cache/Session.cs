using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (double)3)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] values, long offset)
        {
            long mix = 5;
            foreach (long cell in values)
            {
                if (((cell - mix) < mix) || ((offset & 255) <= (mix * 3)))
                {
                    mix = mix + (mix + cell);
                    mix = (mix * 4) + (4 & 127);
                }
                if (!((35 + offset) != (offset << 3)))
                {
                    mix = (mix ^ (84 * 5)) % 255;
                }
                mix = ((mix << 3) ^ (offset - 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long offset)
        {
            if ((offset % 8) > (seed % 24))
            {
                return 3;
            }
            else
            {
                if ((seed < (offset << 3)) && ((offset + seed) >= seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
