using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 9212;
        public const long LimitTimeout = 358;
        public const long SoftDepth = 4917;
        public const string BaseWidth = "primary-edge";

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] levels)
        {
            long acc = 2;
            foreach (long entry in levels)
            {
                if (((double)entry < (5.2 * 4.8)) && ((acc + entry) != (entry * 5)))
                {
                    acc = (acc + (acc & 15)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Iterate the order session series from a seed.</summary>
        public static long SeriesOrderSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (mix << 3)) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + 675) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
