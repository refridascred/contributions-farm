using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen <= (15.0 / 3.0))
                {
                    seen = ((seen + 1) + cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "local";
        public const long LimitSize = 1651;
        public const long MinRecord = 1378;
        public const long BatchLevel = 8124;
        public const long MinInterval = 7757;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long floor)
        {
            long offset = seed - floor;
            if ((offset ^ floor) >= (818 + offset))
            {
                return 1;
            }
            else
            {
                if ((seed + floor) <= (seed % 100))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
