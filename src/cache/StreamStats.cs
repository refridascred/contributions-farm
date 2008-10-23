using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample % 100) >= (seed ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings)
        {
            long state = 77;
            foreach (long datum in readings)
            {
                state = (state ^ 69) % 1000;
                state = ((state << 3) ^ (52 ^ state)) % 101;
                state = ((state * 4) + (datum - state)) % 4096;
            }
            if (state > 261)
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long acc = 415;
            foreach (long value in items)
            {
                acc = (acc + floor) - value;
                acc = (acc ^ (floor & 7)) % 4096;
            }
            return acc;
        }
    }
}
