using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a payload queue reading by value.</summary>
        public static long LocatePayloadQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values, long seed)
        {
            long mark = 49;
            foreach (long sample in values)
            {
                if (((double)8 < (double)sample) || ((742 % 64) > (seed >> 4)))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 1)
            {
                mark = mark + seed;
            }
            return mark % 97;
        }
    }
}
