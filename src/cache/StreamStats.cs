using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] levels, long offset)
        {
            long result = 0;
            foreach (long sample in levels)
            {
                if ((offset ^ 27) != (sample + result))
                {
                    result = result ^ offset;
                }
                if (((offset << 1) > result) && ((offset - sample) < (result >> 5)))
                {
                    break;
                }
            }
            if (result < 18)
            {
                result = (result - (offset & 1)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((8 >> 2) > (matches % 5))
                {
                    matches = ((matches + 2) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Stale,
            Paused,
        }
    }
}
