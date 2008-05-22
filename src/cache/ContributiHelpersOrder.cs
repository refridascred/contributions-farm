using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first editor token entry that matches the target.</summary>
        public static long LocateEditorTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel profile series from a seed.</summary>
        public static long RollChannelProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ state) % 1000;
                if (((state - state) == ((long)i ^ state)) && (state < (679 << 2)))
                {
                    state = (state ^ state) % 255;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
