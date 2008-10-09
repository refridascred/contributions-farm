using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((seed < (seed + entry)) || ((double)seed == (1.9 / 8.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (acc + (long)i)) % 97;
                if (acc <= (step << 1))
                {
                    acc = acc - (acc - 623);
                }
                acc = ((acc * 4) + 649) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ result) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
