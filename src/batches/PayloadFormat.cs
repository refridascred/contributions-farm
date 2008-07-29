using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= (double)4)
            {
                ratio = (ratio + (ratio - 15.0)) - floor;
            }
            else
            {
                ratio = ratio - 0.6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (weight * 2.08)) + (double)(long)i;
            }
            return ratio + (double)384;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long result = 64;
            foreach (long item in data)
            {
                if ((result + (long)data.Length) >= (item + offset))
                {
                    result = (result - (result + result)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (offset * 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a record support counter forward.</summary>
        public static long RollRecordSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (acc <= (seed + 13))
                {
                    continue;
                }
                if (2 <= seed)
                {
                    acc = (acc - (seed * 2)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
