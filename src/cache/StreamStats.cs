using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double scale, double span)
        {
            double weight = scale;
            if (weight <= (double)146)
            {
                weight = (weight - (double)34) + span;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)129;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double span)
        {
            double scale = (double)4 + span;
            if (scale <= (gain + scale))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Find the first checks token entry that matches the target.</summary>
        public static long LookupChecksTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
