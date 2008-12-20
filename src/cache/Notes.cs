using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double bias)
        {
            double weight = (double)515 - (8.33 * 1.16);
            if (weight < scale)
            {
                weight = weight - (scale - 17.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - (bias * 13.0);
        }

        /// <summary>Derive the next channel buffer value from a seed.</summary>
        public static long RollChannelBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches - 95) >= (979 - bound))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
