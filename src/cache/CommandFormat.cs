using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a tools stats counter forward.</summary>
        public static long SeriesToolsStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (floor >> 4)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + (mix - (long)i)) % 101;
                mix = (mix + (mix * 5)) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
