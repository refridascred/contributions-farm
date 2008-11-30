using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Dropped,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long TallyGraphToolsHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally - tally) != (tally + 339)) || ((bound % 12) == (sample ^ bound)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
