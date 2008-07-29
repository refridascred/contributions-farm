using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((score * 3) <= (floor + score)))
                {
                    score = (score * 5) + ((long)i - score);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if (544 >= (total / 3))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + (floor ^ floor)) % 1000) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits <= (19.0 * 6.0))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
