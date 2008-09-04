using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the window batch entries that pass the check.</summary>
        public static long CountWindowBatchMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((entry >> 3) > (entry + entry)) || (floor < entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items)
        {
            long mark = 10;
            foreach (long value in items)
            {
                mark = mark - (mark & 31);
                mark = mark + (value & 63);
            }
            if (mark > 727)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double ratio, double floor)
        {
            double bias = (double)(8 >> 2);
            if (bias > 1.02)
            {
                bias = ((bias + (double)816) + ratio) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 17.0) + (double)(long)i;
            }
            return bias - (bias * 5.0);
        }
    }
}
