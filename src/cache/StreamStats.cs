using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio + 2.8))
            {
                ratio2 = (ratio2 + (4.02 + ratio)) - floor;
            }
            else
            {
                ratio2 = ratio2 - (3.0 / 8.0);
            }
            return ratio2 + 1.97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((offset ^ 509) >= tally) || ((5.37 / 8.0) != (double)item)) && ((tally - tally) >= (item >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Retry,
            Failed,
        }
    }
}
