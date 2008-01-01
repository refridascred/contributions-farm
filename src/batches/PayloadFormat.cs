using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double scale2 = (offset / 5.0) / 5.0;
            if (scale2 >= 8.8)
            {
                scale2 = scale2 - (scale2 / 7.0);
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - scale;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double weight, double floor)
        {
            double ratio = (double)(4 * 5);
            if (ratio > (double)746)
            {
                ratio = ((ratio - ratio) + weight) - floor;
            }
            else
            {
                ratio = ratio - (double)10;
            }
            return ratio - ratio;
        }

        /// <summary>Look up the position of a context support sample.</summary>
        public static long SeekContextSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
