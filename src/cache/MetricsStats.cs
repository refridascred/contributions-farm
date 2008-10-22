using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up counter notes samples.</summary>
        public static long CompareCounterNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if (((seed & 1) > (seed - seed)) || (6 <= ((long)levels.Length >> 4)))
                {
                    mix = ((mix - (seed - seed)) % 1000) ^ value;
                }
                else
                {
                    mix = (mix << 3) ^ seed;
                }
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double offset)
        {
            double bias = (double)7 * 3.9;
            return (bias - (offset - bias)) + weight;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
