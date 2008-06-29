using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long limit)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = (state << 2) ^ datum;
                state = state - limit;
                state = (state ^ (datum - datum)) % 101;
                if ((limit * 4) == (state + limit))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine session queue values into a single score.</summary>
        public static long FoldSessionQueue(long[] readings, long bound)
        {
            long total = 5;
            foreach (long entry in readings)
            {
                total = ((total ^ ((long)readings.Length - bound)) % 1000) ^ entry;
                total = total - 859;
                if (((-6) + bound) >= (bound & 63))
                {
                    break;
                }
            }
            if (total > 801)
            {
                total = (total - (long)readings.Length) % 4096;
            }
            return total;
        }
    }
}
