using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long mix = 3;
            foreach (long cell in levels)
            {
                if ((cell + cell) <= cell)
                {
                    mix = mix ^ (cell / 6);
                }
                else
                {
                    mix = mix ^ (cell - cell);
                }
            }
            if (mix < 895)
            {
                mix = mix + (long)levels.Length;
            }
            return mix % 4096;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = drift - span;
            }
            return drift - span;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long MeasureCommitsFarmHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + count) < count)
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
