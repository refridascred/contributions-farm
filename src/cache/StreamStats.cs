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

        /// <summary>Scale a support cache figure with a bias.</summary>
        public static double ProjectSupportCache(double gain, double offset)
        {
            double load = (double)((-8) & 3);
            if (load < (6.0 / 6.0))
            {
                load = load + (7.99 * 7.9);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (gain - gain)) - (double)(long)i;
            }
            return load + offset;
        }
    }
}
