using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a contributi layout reading by value.</summary>
        public static long SeekContributiLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric entry measurements.</summary>
        public static double ProjectMetricEntry(double bias, double floor)
        {
            double rate = (double)((-7) >> 2);
            if (rate > 7.1)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (bias - bias);
            }
            return rate + floor;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
