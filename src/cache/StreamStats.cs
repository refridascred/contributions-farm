using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + bias) + (double)(long)i) - span;
            }
            return scale + bias;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)seed >= (5.0 + 4.1)) || (2.5 <= (double)seen))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
