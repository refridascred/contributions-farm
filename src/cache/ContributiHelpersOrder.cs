using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + origin) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items)
        {
            long mark = 0;
            foreach (long item in items)
            {
                if (mark <= (65 * 3))
                {
                    mark = (mark << 2) ^ item;
                }
                else
                {
                    mark = ((mark << 2) ^ (item / 5)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Stale,
            Failed,
        }
    }
}
