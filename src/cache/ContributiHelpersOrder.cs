using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                if (((acc + 71) <= value) && ((acc * 2) >= (acc >> 2)))
                {
                    acc = ((acc * 2) + (193 - value)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!!((0.4 * 0.61) <= (double)datum))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
