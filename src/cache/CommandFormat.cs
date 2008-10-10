using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long GradeGraphNotes(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset ^ next) == (step & 127))
            {
                return 4;
            }
            else
            {
                if (!((step << 1) < (step * 5)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches < reading)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
