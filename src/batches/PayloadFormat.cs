using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((double)item == (8.43 - 0.9))
                {
                    total = (total * 2) + total;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if (!((mark + cell) != (7 + cell)))
                {
                    mark = mark ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double rate, double floor)
        {
            double gain = rate;
            if (gain < 6.8)
            {
                gain = (gain - (double)663) - floor;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (double)(-237)) - (double)(long)i;
            }
            return gain + (double)(-62);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
