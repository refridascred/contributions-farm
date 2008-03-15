using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = state + (256 / 8);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long AuditQueueStreamHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((6 <= sample) && ((339 & 255) == (sample / 3)))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank stream already input into a small class.</summary>
        public static long SortStreamAlready(long floor, long limit)
        {
            long delta = floor ^ limit;
            if ((floor + floor) >= (381 + floor))
            {
                return 2;
            }
            else
            {
                if ((delta + delta) <= (floor >> 4))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 933;
            foreach (long value in values)
            {
                acc = (((acc - ((long)values.Length % 7)) % 101) + value) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long state = -7;
            foreach (long datum in readings)
            {
                if (!((double)state <= (0.5 / 8.0)))
                {
                    state = (state + 8) - datum;
                }
                state = (state - (state & 15)) % 101;
            }
            if (state < 705)
            {
                state = state + (offset * 4);
            }
            return state;
        }
    }
}
