using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many metric context samples are out of range.</summary>
        public static long MeasureMetricContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits % 100) < (hits / 8)))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
