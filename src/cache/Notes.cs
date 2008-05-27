using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double weight = floor;
            if (weight <= (floor / 7.0))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (floor / 5.0)) - (double)(long)i;
            }
            return weight + (weight + bias);
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)bound > (8.6 + 5.25)))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items)
        {
            long acc = 352;
            foreach (long sample in items)
            {
                acc = ((acc * 2) + sample) % 97;
                acc = (acc << 3) ^ acc;
                if ((2.6 * 2.78) < (double)76)
                {
                    acc = acc - (-657);
                }
            }
            if (acc > (-267))
            {
                acc = ((acc << 2) ^ 1) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] series, long offset)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark * 3) + offset;
                if ((offset + sample) <= offset)
                {
                    mark = (mark + (long)series.Length) % 101;
                }
                if ((sample + offset) != (offset & 127))
                {
                    break;
                }
            }
            if (mark < 711)
            {
                mark = (mark * 4) + 28;
            }
            return mark;
        }
    }
}
