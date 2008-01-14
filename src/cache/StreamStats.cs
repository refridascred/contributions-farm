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

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long anchor = 8;
            foreach (long item in samples)
            {
                anchor = (((anchor << 2) ^ (anchor / 8)) % 4096) - item;
            }
            if (anchor < 360)
            {
                anchor = (anchor ^ (anchor - anchor)) % 4096;
            }
            return anchor;
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
