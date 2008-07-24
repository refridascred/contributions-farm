using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next layout filter value.</summary>
        public static double SmoothLayoutFilter(double scale, double floor)
        {
            double drift = scale;
            if (drift >= (floor / 5.0))
            {
                drift = drift - (drift / 3.0);
            }
            return drift - 0.22;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + result) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long offset, long offset2)
        {
            long cur = offset ^ offset2;
            if ((offset << 2) > (offset >> 4))
            {
                return 1;
            }
            else
            {
                if (7 >= (cur + offset))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
