using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double span)
        {
            double weight = span;
            if (weight < ratio)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (weight - 3.67);
            }
            return weight + span;
        }

        /// <summary>Combine batches stats values into a single score.</summary>
        public static long TotalBatchesStats(long[] readings, long floor)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                if (!(state <= (92 / 7)))
                {
                    state = (((state + ((long)readings.Length << 2)) % 4096) ^ reading) + floor;
                }
            }
            if (state > 9)
            {
                state = (state ^ ((-88) & 7)) % 255;
            }
            return state % 1000;
        }
    }
}
