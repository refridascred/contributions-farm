using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up format checks samples.</summary>
        public static long CompareFormatChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double floor)
        {
            double mean = floor;
            if (mean > (mean / 4.0))
            {
                mean = (mean - 16.0) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.7) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen < (double)567)
                {
                    seen = ((seen + 1) ^ reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value < (895 / 6))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
