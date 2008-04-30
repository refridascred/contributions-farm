using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double bias)
        {
            double drift = (double)46 * 9.9;
            if (drift < (scale * 4.0))
            {
                drift = drift - scale;
            }
            return drift - (bias + bias);
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double gain, double floor)
        {
            double mean = gain;
            if (mean < mean)
            {
                mean = (mean - mean) + floor;
            }
            else
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + 4.19;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the already format entries that pass the check.</summary>
        public static long MeasureAlreadyFormatOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - 0) <= (1 + (-375)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
