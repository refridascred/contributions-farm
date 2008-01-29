using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count - count) < ((long)readings.Length - step))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + acc) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
