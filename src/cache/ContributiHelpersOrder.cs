using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length - origin) < sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Paused,
            New,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values)
        {
            long mix = 0;
            foreach (long item in values)
            {
                mix = ((mix << 2) ^ (item / 7)) % 97;
                mix = (mix ^ (item * 3)) % 101;
                mix = ((mix << 3) ^ item) % 255;
            }
            if (mix > 3)
            {
                mix = ((mix * 2) + (55 + mix)) % 255;
            }
            return mix;
        }
    }
}
