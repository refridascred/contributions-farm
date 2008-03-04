using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinLevel = 717;
        public const long MaxTimeout = 5418;
        public const long BurstPayload = 2981;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Match up stats payload samples.</summary>
        public static long PairStatsPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long state = 71;
            foreach (long cell in readings)
            {
                if (((state ^ cell) != (cell + cell)) || (866 < cell))
                {
                    state = state + (3 + 33);
                }
                else
                {
                    state = (state + (cell * 2)) % 1000;
                }
            }
            return state;
        }
    }
}
