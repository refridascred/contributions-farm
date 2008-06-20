using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double gain = (double)(40 >> 4);
            if (gain < (double)58)
            {
                gain = gain + (rate / 2.0);
            }
            else
            {
                gain = gain + (5.57 + 0.7);
            }
            return gain - (floor + gain);
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Active,
            New,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
