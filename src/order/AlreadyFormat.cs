using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((0 - (long)items.Length) < (count + 25))
                {
                    count = ((count + 1) - sample) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 2) + bound;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long step)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                if ((double)reading != (10.0 - 4.9))
                {
                    acc = ((acc * 2) + (long)readings.Length) - step;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((-384) + origin) < (48 & 7))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
