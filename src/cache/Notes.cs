using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a cluster format counter forward.</summary>
        public static long DeriveClusterFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits ^ value) != (value % 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double weight, double floor)
        {
            double load = 2.19;
            if (load >= (3.0 + 10.0))
            {
                load = ((load + (double)31) - weight) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)7) + (double)(long)i;
            }
            return load + 8.13;
        }
    }
}
