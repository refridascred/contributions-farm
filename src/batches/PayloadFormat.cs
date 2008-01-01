using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
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

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
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
