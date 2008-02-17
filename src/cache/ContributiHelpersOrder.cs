using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a report queue sample.</summary>
        public static long LookupReportQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step - step) < (step >> 1))
                {
                    mix = (mix << 2) ^ ((long)i * 4);
                    mix = (mix + (mix / 6)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
