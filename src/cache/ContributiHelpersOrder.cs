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

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long TallySchemaQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
