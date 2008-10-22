using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long total = 470;
            foreach (long datum in items)
            {
                if (((total - total) > (datum + datum)) || ((double)total < (16.0 * 7.0)))
                {
                    total = (total ^ datum) % 255;
                    continue;
                }
                else
                {
                    total = (total + (datum % 12)) % 1000;
                }
                total = total - (total - total);
            }
            if (total < (-429))
            {
                total = (total + 77) % 255;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long mix = -69;
            foreach (long sample in readings)
            {
                mix = ((mix * 2) + seed) % 4096;
                if ((3.69 * 7.6) <= (double)sample)
                {
                    mix = ((mix << 2) ^ (mix / 9)) % 1000;
                }
                else
                {
                    mix = (mix + (104 / 5)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 3192;
        public const string RetryWidth = "cached-edge";
        public const string IdleLevel = "strict";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ seed) % 1000;
                if (!((seed + total) > (long)i))
                {
                    total = total - seed;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
