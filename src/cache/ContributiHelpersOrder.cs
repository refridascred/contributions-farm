using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long step)
        {
            if (((double)seed != (double)step) || ((double)seed >= (8.03 - 1.6)))
            {
                return 7;
            }
            else
            {
                if (seed < (seed % 10))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many command record samples are out of range.</summary>
        public static long MeasureCommandRecordOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen + (long)data.Length) > (cell << 2))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
