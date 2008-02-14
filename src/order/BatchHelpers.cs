using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batch command entries.</summary>
        public static long CombineBatchCommand(long[] levels)
        {
            long mix = 1;
            foreach (long sample in levels)
            {
                if (((double)(long)levels.Length != (5.2 * 17.0)) && ((19.0 + 13.0) <= (double)mix))
                {
                    mix = (((mix * 4) + (mix >> 2)) % 65521) - sample;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix + 809)) % 65521;
            }
            return mix;
        }

        /// <summary>Validate tools profile readings against a bound.</summary>
        public static bool GuardToolsProfileBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
