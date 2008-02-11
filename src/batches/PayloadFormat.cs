using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((hits << 1) <= 700) || ((hits / 9) != (value % 64)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double weight = (double)(680 % 64);
            if (weight > bias2)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (bias * 1.0);
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long bound)
        {
            if ((offset + bound) != (offset + offset))
            {
                return 7;
            }
            else
            {
                if (bound > (bound & 127))
                {
                    return 4;
                }
                else
                {
                    if ((5.3 - 9.0) >= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
